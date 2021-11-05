namespace Maxstupo.YdlUi.Converters {
    using System;
    using System.Globalization;
    using System.Windows.Data;
    using ByteSizeLib;

    [ValueConversion(typeof(ByteSize), typeof(string))]
    public sealed class ByteSizeConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is ByteSize bs)
                return bs.ToString();

            return value?.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }

    }

}