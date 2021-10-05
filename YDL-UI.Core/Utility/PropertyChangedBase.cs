namespace Maxstupo.YdlUi.Core.Utility {
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public abstract class PropertyChangedBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}