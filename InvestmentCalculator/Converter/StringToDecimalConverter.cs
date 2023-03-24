using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace InvestmentCalculator.Converter
{
    class StringToDecimalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var princpal = (decimal)value;

            return princpal.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string? textInput = value as string;
            if (string.IsNullOrEmpty(textInput))
            {
                return 0m;
            }
            else
            {
                try
                {
                    return Decimal.Parse(textInput, culture);
                }
                catch (Exception)
                {
                    return DependencyProperty.UnsetValue;
                }
            }
        }
    }
}
