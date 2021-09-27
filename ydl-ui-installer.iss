; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "YDL-UI"

;/DConfiguration=Debug
#ifndef Configuration
    #define Configuration "Release"
#endif

;/DApplicationVersion=1.0.0
#ifndef ApplicationVersion
    #define ApplicationVersion RemoveFileExt(GetVersionNumbersString("YDL-UI\bin\" + Configuration + "\YDL-UI.exe"))
#endif

#define MyAppPublisher "Maxstupo"
#define MyAppURL "https://github.com/Maxstupo/ydl-ui"
#define MyAppExeName "YDL-UI.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{0A6FD646-37BC-40F2-AD19-011B5C606420}}
AppName={#MyAppName}
AppVersion={#ApplicationVersion}
AppVerName={#MyAppName} v{#ApplicationVersion}
UninstallDisplayName={#MyAppName}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; The [Icons] "quicklaunchicon" entry uses {userappdata} but its [Tasks] entry has a proper IsAdminInstallMode Check.
UsedUserAreasWarning=no
LicenseFile=LICENSE
; Remove the following line to run in administrative install mode (install for all users.)
PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=commandline
OutputDir=.
OutputBaseFilename=YDL-UI-Setup_v{#ApplicationVersion}
;SetupIconFile=YDL-UI\YDL-UI.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"
Name: "italian"; MessagesFile: "compiler:Languages\Italian.isl"
Name: "polish"; MessagesFile: "compiler:Languages\Polish.isl"
Name: "portuguese"; MessagesFile: "compiler:Languages\Portuguese.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 6.1; Check: not IsAdminInstallMode

[Files]
Source: "YDL-UI\bin\{#Configuration}\YDL-UI.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "YDL-UI\bin\{#Configuration}\YDL-UI.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "YDL-UI\bin\{#Configuration}\*.dll"; DestDir: "{app}"; 
Source: "YDL-UI\bin\{#Configuration}\NLog.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "YDL-UI\bin\{#Configuration}\LICENSE"; DestDir: "{app}"; Flags: ignoreversion
Source: "YDL-UI\bin\{#Configuration}\locales\*"; DestDir: "{app}\locales"; Flags: ignoreversion recursesubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

