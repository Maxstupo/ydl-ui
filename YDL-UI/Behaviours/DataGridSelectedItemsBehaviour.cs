namespace Maxstupo.YdlUi.Behaviours {
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Interactivity;

    public class DataGridSelectedItemsBlendBehavior : Behavior<DataGrid> {
        public static readonly DependencyProperty SelectedItemProperty = DependencyProperty.Register("SelectedItems", typeof(IList<object>), typeof(DataGridSelectedItemsBlendBehavior), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });

        public IList<object> SelectedItems {
            get => (IList<object>) GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        protected override void OnAttached() {
            base.OnAttached();
            this.AssociatedObject.SelectionChanged += OnSelectionChanged;
        }

        protected override void OnDetaching() {
            base.OnDetaching();
            if (this.AssociatedObject != null)
                this.AssociatedObject.SelectionChanged -= OnSelectionChanged;
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (e.AddedItems != null && e.AddedItems.Count > 0 && this.SelectedItems != null) {
                foreach (object obj in e.AddedItems)
                    this.SelectedItems.Add(obj);
            }

            if (e.RemovedItems != null && e.RemovedItems.Count > 0 && this.SelectedItems != null) {
                foreach (object obj in e.RemovedItems)
                    this.SelectedItems.Remove(obj);
            }

        }

    }

}
