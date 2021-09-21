#
# This script optionally builds and then packages YDL-UI into a setup installer executable and portable zipped version.
# Version information is read from version.txt, it can be overwritten with a param.
# This script requires 7-Zip, Inno Setup 6, and optionally msbuild
#
param($config='Release',$build='true',$version='',$versiondisplay='',$title='YDL-UI',$project_name='YDL-UI',$iss='ydl-ui-installer.iss')

$env:Path += ";C:\Program Files (x86)\Inno Setup 6;C:\Program Files\7-Zip"


# Setup script if running outside of AppVeyor. 
if (!$env:APPVEYOR) {
    function Update-SourceVersion {
      Param ([string]$Version,[string]$VersionInformational)
      $NewVersion = 'AssemblyVersion("' + $Version + '")';
      $NewFileVersion = 'AssemblyFileVersion("' + $Version + '")';
      $NewInformationalVersion = 'AssemblyInformationalVersion("' + $VersionInformational + '")';

      foreach ($o in $input) {
        Write-output $o.FullName
        $TmpFile = $o.FullName + ".tmp"

         Get-Content $o.FullName -encoding utf8 |
            %{$_ -replace 'AssemblyVersion\("[0-9]+(\.([0-9]+|\*)){1,3}"\)', $NewVersion } |
            %{$_ -replace 'AssemblyFileVersion\("[0-9]+(\.([0-9]+|\*)){1,3}"\)', $NewFileVersion }  |
            %{$_ -replace 'AssemblyInformationalVersion\("v?[0-9]+(\.([0-9]+|\*)){1,3}(?:\-.+)?"\)', $NewInformationalVersion }  |
            Set-Content $TmpFile -encoding utf8
    
        Move-Item $TmpFile $o.FullName -force
      }
    }

    $env:TITLE = $title
    $env:PROJECT_NAME = $project_name
    $env:ISS = $iss
    
    $env:CONFIGURATION = $config

    if(!$version) {
        $VERSION_FILE = "./version.txt"

        if ((Test-Path $VERSION_FILE -PathType leaf)) { # if the file exists, read the version
            Write-Host "Found version file..."
            $appversion = Get-Content $VERSION_FILE -First 1
        } else {
            Write-Error "Failed to find version file!"
            exit
        }

    } else {
        $appversion = $version
    }

    
    if(!$versiondisplay) {
        $versiondisplay = $appversion
    }

    $versiondisplay = "$versiondisplay-custom"

    # Patch assemblyInfo files
    Get-ChildItem -Recurse |? {$_.Name -eq "AssemblyInfo.cs"} | Update-SourceVersion -Version $appversion -VersionInformational $versiondisplay
    
    if($build -eq 'true') {
        Write-Host "################# Restoring Dependencies #################"  
        msbuild "$env:PROJECT_NAME.sln" /t:Restore
   
        Write-Host "################# Building #################"  
        msbuild "$env:PROJECT_NAME.sln" /P:Configuration=$config
    }
} else {
    $appversion = $env:APP_VERSION_INFORMATIONAL
}

# Copy and archive all files needed for portable version 
Write-Host "################# Packaging Portable Edition #################"   
$portable_folder = "$env:TITLE-Portable_v$appversion"

New-Item -Path $portable_folder -ItemType Directory
Copy-Item -Exclude '*.pdb' "$env:PROJECT_NAME/bin/$env:CONFIGURATION/*" $portable_folder -Force -Recurse -Verbose

# Make the portable version
7z a "$portable_folder.zip" "$portable_folder"

# Remove temp folder
Get-ChildItem -Path $portable_folder -Recurse | Remove-Item -Force -Recurse
Remove-Item $portable_folder -Force


# Make the installer
Write-Host "################# Building Installer #################"
iscc $env:ISS /DConfiguration=$env:CONFIGURATION /DApplicationVersion=$appversion


# Pause if running outside of AppVeyor
if (!$env:APPVEYOR) { 
    Write-Host "Build Done" 
    pause 
}