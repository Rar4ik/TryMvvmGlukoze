﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace TryMvvmGlukoze
{
    class MyConverter : IValueConverter
    {
        private char dot = '.';
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value.ToString().Contains(dot)) return value.ToString().Replace(".", ",");
            else if (value != null) return value.ToString();
            else return null;
        }
    }
}
