namespace Maxstupo.YdlUi.Converters {
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    [ValueConversion(typeof(bool), typeof(Visibility))]
    public sealed class BooleanVisibilityConverter : DependencyObject, IValueConverter {

        /// <summary>Property specifying the Visibility to return when the parameter is true.</summary>
        public static readonly DependencyProperty TrueVisibilityProperty =
            DependencyProperty.Register(nameof(TrueVisibility), typeof(Visibility), typeof(BooleanVisibilityConverter), new PropertyMetadata(Visibility.Visible));

        /// <summary>Property specifying the Visibility to return when the parameter is false.</summary>
        public static readonly DependencyProperty FalseVisibilityProperty =
            DependencyProperty.Register(nameof(FalseVisibility), typeof(Visibility), typeof(BooleanVisibilityConverter), new PropertyMetadata(Visibility.Collapsed));

        /// <summary>The Visibility value to use if the boolean is false.</summary>
        public Visibility FalseVisibility {
            get => (Visibility) GetValue(FalseVisibilityProperty);
            set => SetValue(FalseVisibilityProperty, value);
        }

        /// <summary>The Visibility value to use if the boolean is true.</summary>
        public Visibility TrueVisibility {
            get => (Visibility) GetValue(TrueVisibilityProperty);
            set => SetValue(TrueVisibilityProperty, value);
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is bool b)
                return b ? TrueVisibility : FalseVisibility;
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is Visibility b)
                return b == TrueVisibility ? true : b == FalseVisibility ? false : value;
            return value;
        }

    }

    [ValueConversion(typeof(Enum), typeof(Visibility))]
    public sealed class EnumVisibilityConverter : DependencyObject, IValueConverter {

        /// <summary>Property specifying the Visibility to return when the parameter is true.</summary>
        public static readonly DependencyProperty TrueVisibilityProperty =
            DependencyProperty.Register(nameof(TrueVisibility), typeof(Visibility), typeof(EnumVisibilityConverter), new PropertyMetadata(Visibility.Visible));

        /// <summary>Property specifying the Visibility to return when the parameter is false.</summary>
        public static readonly DependencyProperty FalseVisibilityProperty =
            DependencyProperty.Register(nameof(FalseVisibility), typeof(Visibility), typeof(EnumVisibilityConverter), new PropertyMetadata(Visibility.Collapsed));

        /// <summary>The Visibility value to use if the boolean is false.</summary>
        public Visibility FalseVisibility {
            get => (Visibility) GetValue(FalseVisibilityProperty);
            set => SetValue(FalseVisibilityProperty, value);
        }

        /// <summary>The Visibility value to use if the boolean is true.</summary>
        public Visibility TrueVisibility {
            get => (Visibility) GetValue(TrueVisibilityProperty);
            set => SetValue(TrueVisibilityProperty, value);
        }

        private static readonly EnumBooleanConverter converter = new EnumBooleanConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            bool va = (bool) converter.Convert(value, targetType, parameter, culture);
            return va ? TrueVisibility : FalseVisibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotSupportedException();
        }

    }

}