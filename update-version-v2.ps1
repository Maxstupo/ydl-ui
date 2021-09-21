#
# Updates the build version using the last existing version tag (e.g. v1.0.0) and provides environment variables for both normal and informational versions.
# 
# Notes: 
# - Tag versioning only supported for master branch.
# - Non-master branches will use a fixed version, defined in "pinned-version.txt" or in an environment variable "NON_MASTER_VERSION"
# - Non-master branches will use the branch name for the build suffix, if master branch the suffix will be taken from the tag name if available.
# - Tag name should be "major.minor.patch" (prefixing "v" is supported/optional)
# - $env:BUILD_VERSION will always be "major.minor.patch"
# - $env:APP_VERSION will always be "major.minor.patch.build" but tag builds will have the build zeroed.
# - $env:APP_INFORMATIONAL_VERSION will be "major.minor.patch[-suffix]" during tag builds and "major.minor.patch.build[-suffix]" during normal builds.

$TAG_REGEX = 'v?(\d+\.\d+\.\d+)(?:\-(.+))?'

if (!$env:APPVEYOR) {
    Write-Error "Script not running in AppVeyor. Exiting..."
    exit
}

$VERSION_FILE = "$env:APPVEYOR_BUILD_FOLDER/version.txt"

$BUILD_SUFFIX = ""
$BUILD_NUMBER = $env:APPVEYOR_BUILD_NUMBER
 
if ($env:APPVEYOR_REPO_TAG -eq $true) { # Build has a tag
    $found = $env:APPVEYOR_REPO_TAG_NAME -match $TAG_REGEX

    $env:BUILD_VERSION = $matches[1]
    $BUILD_SUFFIX = $matches[2]

    $BUILD_NUMBER = "0"

    Write-Host "Using commit tag for versioning: v$env:BUILD_VERSION"
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
      
        if ((Test-Path $VERSION_FILE -PathType leaf)) { # if the file exists, read the version
            Write-Host "Found version file..."
            $PINNED_VERSION = Get-Content $VERSION_FILE -First 1
        } else {
            Write-Host "Failed to find version file, using environment variable NON_MASTER_VERSION"
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


if ($env:APPVEYOR_REPO_TAG -eq $true) {
    # "major.minor.patch[-suffix]"
    $env:APP_VERSION_INFORMATIONAL = "$env:BUILD_VERSION$BUILD_SUFFIX"
} else {
    # "major.minor.patch.build[-suffix]"
    $env:APP_VERSION_INFORMATIONAL = "$env:APP_VERSION$BUILD_SUFFIX"
}

Write-Host "BUILD_VERSION: $env:BUILD_VERSION"
Write-Host "APP_VERSION: $env:APP_VERSION"
Write-Host "APP_VERSION_INFORMATIONAL: $env:APP_VERSION_INFORMATIONAL"

# "major.minor.patch.build[-suffix]"
Update-AppveyorBuild -Version "$env:APP_VERSION$BUILD_SUFFIX"