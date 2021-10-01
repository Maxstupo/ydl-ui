namespace Maxstupo.YdlUi.Controls {
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using Stylet;

    public sealed class VisualSelectorPage {

        public object Header { get; }

        public string Id { get; }

        public string Name { get; }

        public string LocalizationBase { get; }

        public string LocalizationPath => $"{LocalizationBase}{Id}";

        public VisualSelectorPage(object header, string id, string localizationBase, string name) {
            this.Header = header;
            this.Id = id;
            this.LocalizationBase = string.IsNullOrEmpty(localizationBase) ? string.Empty : $"{localizationBase}.";
            this.Name = name;
        }

        public override string ToString() {
            return Id;
        }

    }

    public sealed class PageSelector : ContentControl {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();


        #region Dependency Properties

        public BindableCollection<UIElement> Elements {
            get => (BindableCollection<UIElement>) GetValue(ElementsProperty);
            set => SetValue(ElementsProperty, value);
        }

        public static readonly DependencyProperty ElementsProperty =
            DependencyProperty.Register(nameof(Elements), typeof(BindableCollection<UIElement>), typeof(PageSelector), new PropertyMetadata(new BindableCollection<UIElement>(), Elements_PropertyChanged));


        public string SelectedPageId {
            get => (string) GetValue(SelectedPageIdProperty);
            set => SetValue(SelectedPageIdProperty, value);
        }

        public static readonly DependencyProperty SelectedPageIdProperty =
            DependencyProperty.Register(nameof(SelectedPageId), typeof(string), typeof(PageSelector), new PropertyMetadata(default(string), SelectedPageId_PropertyChanged));
      

        public string LocalizationBase {
            get => (string) GetValue(LocalizationBaseProperty);
            set => SetValue(LocalizationBaseProperty, value);
        }

        public static readonly DependencyProperty LocalizationBaseProperty =
            DependencyProperty.Register(nameof(LocalizationBase), typeof(string), typeof(PageSelector), new PropertyMetadata(default(string)));


        public string DesignTimeSelectedPageId {
            get => (string) GetValue(DesignTimeSelectedPageIdProperty);
            set => SetValue(DesignTimeSelectedPageIdProperty, value);
        }

        public static readonly DependencyProperty DesignTimeSelectedPageIdProperty =
            DependencyProperty.Register(nameof(DesignTimeSelectedPageId), typeof(string), typeof(PageSelector), new PropertyMetadata(default(string), DesignTimePageId_PropertyChanged));


        public BindableCollection<VisualSelectorPage> Pages {
            get => (BindableCollection<VisualSelectorPage>) GetValue(PagesProperty);
            set => throw new InvalidOperationException($"{nameof(Pages)} dependency property is readonly!");
        }

        public static readonly DependencyProperty PagesProperty =
            DependencyProperty.Register(nameof(Pages), typeof(BindableCollection<VisualSelectorPage>), typeof(PageSelector), new PropertyMetadata(new BindableCollection<VisualSelectorPage>()));


        public string PageFilter {
            get => (string) GetValue(PageFilterProperty);
            set => SetValue(PageFilterProperty, value);
        }

        public static readonly DependencyProperty PageFilterProperty =
            DependencyProperty.Register(nameof(PageFilter), typeof(string), typeof(PageSelector), new PropertyMetadata(default(string), PageFilter_PropertyChanged));


        public VisualSelectorPage SelectedPage {
            get => (VisualSelectorPage) GetValue(SelectedPageProperty);
            set => throw new InvalidOperationException($"{nameof(SelectedPage)} dependency property is readonly!");
        }

        public static readonly DependencyProperty SelectedPageProperty =
            DependencyProperty.Register(nameof(SelectedPage), typeof(VisualSelectorPage), typeof(PageSelector), new PropertyMetadata(null));


        #endregion


        #region Attached Properties

        public static readonly DependencyProperty PageIdProperty =
            DependencyProperty.RegisterAttached("PageId", typeof(string), typeof(PageSelector), new PropertyMetadata(default(string)));

        public static string GetPageId(DependencyObject obj) => (string) obj.GetValue(PageIdProperty);
        public static void SetPageId(DependencyObject obj, string value) => obj.SetValue(PageIdProperty, value);


        public static readonly DependencyProperty PreventScrollingProperty =
            DependencyProperty.RegisterAttached("PreventScrolling", typeof(bool), typeof(PageSelector), new PropertyMetadata(default(bool)));

        public static bool GetPreventScrolling(DependencyObject obj) => (bool) obj.GetValue(PreventScrollingProperty);
        public static void SetPreventScrolling(DependencyObject obj, bool value) => obj.SetValue(PreventScrollingProperty, value);


        public static readonly DependencyProperty HeaderProperty =
           DependencyProperty.RegisterAttached("Header", typeof(UIElement), typeof(PageSelector), new PropertyMetadata(null));

        public static UIElement GetHeader(DependencyObject obj) => (UIElement) obj.GetValue(HeaderProperty);
        public static void SetHeader(DependencyObject obj, UIElement value) => obj.SetValue(HeaderProperty, value);


        public static readonly DependencyProperty PageNameProperty =
         DependencyProperty.RegisterAttached("PageName", typeof(string), typeof(PageSelector), new PropertyMetadata(default(string)));

        public static string GetPageName(DependencyObject obj) => (string) obj.GetValue(PageNameProperty);
        public static void SetPageName(DependencyObject obj, string value) => obj.SetValue(PageNameProperty, value);

        #endregion


        public PageSelector() {
            Elements = new BindableCollection<UIElement>();
            SetValue(PagesProperty, new BindableCollection<VisualSelectorPage>());

            Loaded += PageSelector_Loaded;
        }

        private void PageSelector_Loaded(object sender, RoutedEventArgs e) {
            SetValue(SelectedPageProperty, GetPage(SelectedPageId));

            UpdatePages();
            RefreshPageContent();
        }

        private static void Elements_PropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            PageSelector pageSelector = (PageSelector) d;
            pageSelector.UpdatePages();
            pageSelector.ElementsChanged(e.OldValue as BindableCollection<UIElement>, e.NewValue as BindableCollection<UIElement>);
        }

        private static void SelectedPageId_PropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            PageSelector pageSelector = ((PageSelector) d);
            pageSelector.SetValue(SelectedPageProperty, pageSelector.GetPage(e.NewValue as string));

            pageSelector.RefreshPageContent();
        }
            
        private void Elements_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            UpdatePages();
            RefreshPageContent();
        }

        private static void DesignTimePageId_PropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            ((PageSelector) d).RefreshPageContent();
        }

        private void ElementsChanged(BindableCollection<UIElement> oldValue, BindableCollection<UIElement> newValue) {
            if (oldValue != null)
                oldValue.CollectionChanged -= Elements_CollectionChanged;

            if (newValue != null)
                newValue.CollectionChanged += Elements_CollectionChanged;

            RefreshPageContent();
        }

        private void RefreshPageContent() {
            if (Elements == null)
                return;

            string id = DesignerProperties.GetIsInDesignMode(this) ? DesignTimeSelectedPageId : SelectedPageId;

            Content = GetPageContent(id);
        }

        private void UpdatePages() {
            Pages.Clear();

            bool checkFilter = !string.IsNullOrWhiteSpace(PageFilter);

            foreach (UIElement element in Elements) {
                if (checkFilter && !ContainsText(element, PageFilter))
                    continue;

                VisualSelectorPage page = GetPage(element);
                if (page != null)
                    Pages.Add(page);
            }

        }

        private VisualSelectorPage GetPage(UIElement x) {
            if (x == null)
                return null;

            string id = GetPageId(x);
            if (id == null)
                return null;
            return new VisualSelectorPage(GetHeader(x), id, LocalizationBase, GetPageName(x));
        }

        private VisualSelectorPage GetPage(string id) {
            return GetPage(GetPageContent(id));
        }

        public UIElement GetPageContent(string id) {
            return Elements.FirstOrDefault(x => GetPageId(x) == id);
        }


        private static void PageFilter_PropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            ((PageSelector) d).UpdatePages();
        }

        private static bool ContainsText(UIElement root, string filter) {

            foreach (UIElement child in FindVisualChildren<UIElement>(root)) {
                if (child is TextBlock text) {
                    if (text.Text.IndexOf(filter, StringComparison.InvariantCultureIgnoreCase) >= 0)
                        return true;
                }

                if (child is ContentControl cc) {
                    if (cc.Content != null && cc.Content.ToString().IndexOf(filter, StringComparison.InvariantCultureIgnoreCase) >= 0)
                        return true;
                }

            }

            return false;
        }

        private static IEnumerable<T> FindVisualChildren<T>(DependencyObject obj) where T : DependencyObject {
            if (obj != null) {
                int count = VisualTreeHelper.GetChildrenCount(obj);
                for (int i = 0; i < count; i++) {
                    DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                    if (child != null && child is T t)
                        yield return t;

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                        yield return childOfChild;
                }
            }
        }


    }

}