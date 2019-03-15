﻿
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace _03_Fasetto_World
{
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
