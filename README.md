# YDL-UI
<p float="left" align="left" width="100%">
 <img src="https://img.shields.io/github/license/Maxstupo/ydl-ui.svg" />
 <img src="https://img.shields.io/github/release/Maxstupo/ydl-ui.svg" />
 <img src="https://img.shields.io/github/downloads/Maxstupo/ydl-ui/total.svg" />
 <a href="https://ci.appveyor.com/project/Maxstupo/ydl-ui?branch=dev/v3">
    <img src="https://ci.appveyor.com/api/projects/status/v0hl8me24o12u1xt/branch/dev/v3?svg=true" />
 </a>
 <a href="https://www.transifex.com/ydl-apps/ydl-ui">
    <img src="https://img.shields.io/badge/localized_with-Transifex-success?svg=true" alt="localized with Transifex" />
 </a>
</p>

Development branch for v3.0 of YDL-UI

A UI for the command-line video downloader "youtube-dl"

YDL-UI provides a simplified way to download videos using "youtube-dl", without the hassle of using the command-line. This is achieved by dynamically generating youtube-dl argument queries that can be run with a click of a button. YDL-UI is packaged with a release of youtube-dl and ffmpeg.

# Building the Project

You can download a development build from [AppVeyor - dev/v3 branch](https://ci.appveyor.com/project/Maxstupo/ydl-ui?branch=dev/v3) or you can manually build the repository.

The `package-build.ps1` script can build and package YDL-UI into an installer and portable zip file. It requires the following to be installed: 7-Zip, Inno Setup 6, and MSBuild (on path)
```
git clone --recurse-submodules -b dev/v3 https://github.com/Maxstupo/ydl-ui.git
./package-build.ps1
```
If you don't care about packaged builds, you can just build the solution in Visual Studio and directly use the files in the output directory.

# License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details
