namespace Maxstupo.YdlUi.Converters {
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    [ValueConversion(typeof(TimeSpan), typeof(string))]
    public sealed class TimeSpanConverter : DependencyObject, IValueConverter {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is TimeSpan b)
                return b.ToString();
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }

    }

}