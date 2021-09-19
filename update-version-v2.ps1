#
# Updates the build version using the last existing version tag (e.g. v1.0.0) and provides environment variables for both normal and informational versions.
# 
# Requires secure environment variable named "APPVEYOR_TOKEN" for AppVeyor REST API
#
# Notes: 
# - Tag versioning only supported for master branch.
# - Non-master branches will use a fixed version, defined in "pinned-version.txt" or in an environment variable "NON_MASTER_VERSION"
# - Non-master branches will use the branch name for the build suffix, if master branch the suffix will be taken from the tag name if available.
# - Tag name should be "major.minor.patch" (prefixing "v" is supported/optional)
# - Tag builds will reset the build number.
# - $env:BUILD_VERSION will always be "major.minor.patch"
# - $env:APP_VERSION will always be "major.minor.patch.build"
# - $env:APP_INFORMATIONAL_VERSION will be v"major.minor.patch.build" or v"major.minor.patch" during tag builds, and will have the tag suffix appended if exists (e.g. v1.0.0-pr3).

$TAG_REGEX = 'v?(\d+\.\d+\.\d+)(?:\-(.+))?'

if (!$env:APPVEYOR) {
    Write-Error "Script not running in AppVeyor. Exiting..."
    exit
}

function Reset-BuildNumber() {
        $headers = @{
            "Authorization" = "Bearer $env:APPVEYOR_TOKEN"
            "Content-type" = "application/json"
            "Accept" = "application/json"
        }
        $json = @{
            nextBuildNumber = 1
        } | ConvertTo-Json
        
        Invoke-RestMethod -Method Put "https://ci.appveyor.com/api/projects/$env:APPVEYOR_ACCOUNT_NAME/$env:APPVEYOR_PROJECT_SLUG/settings/build-number" -Body $json -Headers $headers
        
}

$BUILD_NUMBER = $env:APPVEYOR_BUILD_NUMBER
$BUILD_SUFFIX = ""


if ($env:APPVEYOR_REPO_TAG -eq $true) { # Build has a tag
    $found = $env:APPVEYOR_REPO_TAG_NAME -match $TAG_REGEX

    $env:BUILD_VERSION = $matches[1]
    $BUILD_SUFFIX = $matches[2]

    Write-Host "Using commit tag for versioning: v$env:BUILD_VERSION"    
    Write-Host "Resetting build number, since tag is defined!"
    $BUILD_NUMBER = "0"
    Reset-BuildNumber
} else { 
    if ($env:APPVEYOR_REPO_BRANCH -like 'master') { # if the master branch, use tag versioning - use the last tag available
        Write-Host "Master branch, using tag versioning..."    
        $HASH = $(git rev-list --tags --max-count=1)

        if ($HASH) {  
            $found = $(git describe --tags $HASH) -match $TAG_REGEX
           
            $env:BUILD_VERSION = $matches[1]
            $BUILD_SUFFIX = $matches[2]

            Write-Host "Using latest existing tag for versioning: v$env:BUILD_VERSION"
        } else {
            $env:BUILD_VERSION = "0.0.0"

            Write-Host "Setting version to zero, no previous tags: v$env:BUILD_VERSION"       
        }
    } else { # Not the master branch
        Write-Host "Not master branch, using predefined version..."
        $VERSION_FILE = "$env:APPVEYOR_BUILD_FOLDER/pinned-version.txt"

        if ((Test-Path $VERSION_FILE -PathType leaf)) { # if the file exists, read the version
            Write-Host "Found pinned version file..."
            $PINNED_VERSION = Get-Content $VERSION_FILE -First 1
        } else {
            Write-Host "Failed to find pinned version file, using environment variable NON_MASTER_VERSION"
            $PINNED_VERSION = $env:NON_MASTER_VERSION
        }

        $found = $PINNED_VERSION -match $TAG_REGEX

        $env:BUILD_VERSION = $matches[1]
        $BUILD_SUFFIX = $env:APPVEYOR_REPO_BRANCH -replace "/","-"
    }
}


# Append build suffix if exists (e.g. -dev)
if ($BUILD_SUFFIX) {
    $BUILD_SUFFIX = "-$BUILD_SUFFIX"
}

# "major.minor.patch.build"
$env:APP_VERSION = "$env:BUILD_VERSION.$BUILD_NUMBER"

# "major.minor.patch.build[-suffix]"
$env:APP_VERSION_INFORMATIONAL = "v$env:APP_VERSION$BUILD_SUFFIX"

# When building from tag, exclude build number from informational version.
# "major.minor.patch[-suffix]"
if ($env:APPVEYOR_REPO_TAG -eq "true") {
    Write-Host "Tag defined, excluding build number from informational version."
    $env:APP_VERSION_INFORMATIONAL = "v$env:BUILD_VERSION$BUILD_SUFFIX"
}

Write-Host "BUILD_VERSION: $env:BUILD_VERSION"
Write-Host "APP_VERSION: $env:APP_VERSION"
Write-Host "APP_VERSION_INFORMATIONAL: $env:APP_VERSION_INFORMATIONAL"