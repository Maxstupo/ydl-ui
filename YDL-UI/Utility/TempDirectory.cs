using System;
using System.IO;
using System.Windows.Forms;

namespace Maxstupo.YdlUi.Utility {
    /// <summary>
    /// A class representing a temp directory. Upon the creation of a <see cref="TempDirectory"/> object, the folder will be created.
    /// <para/>
    /// Supports deletion of directory when the application exits. (WinForms)
    /// </summary>
    public class TempDirectory {

        /// <summary>
        /// The filename prefix of the temp directory.
        /// </summary>
        public string Label { get; }

        /// <summary>
        /// If true a random suffix will be added to the filename.
        /// </summary>
        public bool RandomSuffix { get; }

        /// <summary>
        /// The filename of the temp directory.
        /// </summary>
        public string DirectoryName { get; }

        /// <summary>
        /// The info object representing the temporary folder.
        /// </summary>
        public DirectoryInfo Info { get; }

        private bool deleteOnExit = false;
        private Action<DirectoryInfo> deleteOnExitAction;

        /// <summary>
        /// Creates a new temp directory located in the current user's temporary folder.
        /// </summary>
        /// <param name="label">The filename prefix of the temp directory.</param>
        /// <param name="randomSuffix">If true a random suffix will be added to the filename (after the label).</param>
        public TempDirectory(string label, bool randomSuffix = true) {
            this.Label = label ?? throw new ArgumentNullException(nameof(label));
            this.RandomSuffix = randomSuffix;

            string suffix = randomSuffix ? $".{Path.GetRandomFileName()}" : string.Empty;
            DirectoryName = $"{label}{suffix}";

            string path = Path.Combine(Path.GetTempPath(), DirectoryName);
            Info = Directory.CreateDirectory(path);

        }

        /// <summary>
        /// Mark this <see cref="TempDirectory"/> to be deleted on application exit.
        /// </summary>
        /// <returns>This object for chaining.</returns>
        public TempDirectory DeleteOnExit(Action<DirectoryInfo> deleteOnExitAction = null) {
            if (deleteOnExit)
                return this;
            this.deleteOnExitAction = deleteOnExitAction;

            Application.ApplicationExit += OnExit;
            deleteOnExit = true;

            return this;
        }

        private void OnExit(object sender, EventArgs e) {
            deleteOnExitAction?.Invoke(Info);
            Delete();
        }

        /// <summary>
        /// Delete this temp directory, and unregister "deletion on exit" if needed.
        /// </summary>
        /// <returns>True if directory was deleted, false if the directory doesn't exist or deletion failed.</returns>
        public bool Delete() {
            if (!Info.Exists)
                return false;

            try {
                Info.Delete(true);

                if (deleteOnExit)
                    Application.ApplicationExit -= OnExit;

                return true;
            } catch (Exception) {
                Console.WriteLine($"Failed to delete temp directory - {Info.FullName}");
            }
            return false;
        }

    }
}
