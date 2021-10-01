namespace Maxstupo.YdlUi.Converters {
    using System;
    using System.Globalization;
    using System.Windows.Data;
    using Maxstupo.YdlUi.Core.Localization;

    /// <summary>
    /// A converter that translates the second value (as a key) using the first value as the II18N implementation.
    /// </summary>
    public sealed class I18NConverter : IMultiValueConverter {

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            if (values.Length >= 2) {
                if (values[0] is II18N i18n && values[1] is string str)
                    return i18n[str];
            }
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }

    }

}