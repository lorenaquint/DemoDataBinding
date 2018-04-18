﻿

namespace DemoDataBinding
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;
    using Xamarin.Forms;
    public class Converters : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var saldo = (decimal)value;
            var color = Color.Green;
            if (saldo < 5000)
            {
                color = Color.Red;
            }
            else if (saldo >= 5000 && saldo <= 10000)
            {
                color = Color.Orange;
            }
            return color;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
