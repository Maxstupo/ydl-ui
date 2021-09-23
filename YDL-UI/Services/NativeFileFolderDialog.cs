namespace Maxstupo.YdlUi.Services {
    using System;
    using System.Linq;
    using System.Windows;
    using Microsoft.Win32;
    using Microsoft.WindowsAPICodePack.Dialogs;

    ///<summary>Implementation for native Microsoft Windows file and folder, save and open dialogs.</summary>
    public sealed class NativeFileFolderDialog : IFileFolderDialog {

        // private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public string[] ShowOpenFileDialog(string title, string filter = null, bool multiselect = false, string initialDirectory = null, object owner = null) {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Title = title,
                Multiselect = multiselect,
                InitialDirectory = initialDirectory,
                CheckFileExists = true,
                CheckPathExists = true,
                AddExtension = filter != null,
                Filter = filter
            };

            bool result = openFileDialog.ShowDialog(owner as Window).GetValueOrDefault(false);

            return result ? openFileDialog.FileNames : Array.Empty<string>();
        }

        public string ShowSaveFileDialog(string title, string filter = null, bool checkFileExists = true, string initialDirectory = null, object owner = null) {
            SaveFileDialog saveFileDialog = new SaveFileDialog {
                Title = title,
                InitialDirectory = initialDirectory,
                CheckFileExists = checkFileExists,
                CheckPathExists = true,
                AddExtension = filter != null,
                Filter = filter
            };

            bool result = saveFileDialog.ShowDialog(owner as Window).GetValueOrDefault(false);

            return result ? saveFileDialog.FileName : null;
        }

        public string[] ShowOpenFolderDialog(string title, bool multiselect = false, string initialDirectory = null, object owner = null) {
            using (CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog(title)) {
                openFileDialog.IsFolderPicker = true;
                openFileDialog.InitialDirectory = initialDirectory;
                openFileDialog.EnsureFileExists = true;
                openFileDialog.EnsurePathExists = true;
                openFileDialog.Multiselect = multiselect;

                if ((owner == null ? openFileDialog.ShowDialog() : openFileDialog.ShowDialog(owner as Window)) == CommonFileDialogResult.Ok)
                    return openFileDialog.FileNames.ToArray();
            }

            return Array.Empty<string>();
        }

    }

}