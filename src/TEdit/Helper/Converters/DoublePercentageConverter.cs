﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace TEdit.Converters
{
    public class ByteIntConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (byte)(int)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)(byte)value;
        }
    }

    public class ShortIntConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)(short)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (short)(int)value;
        }
    }

    public class IntByteConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)(byte)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (byte)(int)value;
        }
    }

    public class DoublePercentageConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter,
                              CultureInfo culture)
        {
            if (string.IsNullOrEmpty(value.ToString())) return 0;

            if (value.GetType() == typeof (double)) return (double) value;

            if (value.GetType() == typeof (decimal)) return (decimal) value;

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
                                  CultureInfo culture)
        {
            if (string.IsNullOrEmpty(value.ToString())) return 0;

            string trimmedValue = value.ToString().TrimEnd(new[] {'%'});

            if (targetType == typeof (double))
            {
                double result;
                if (double.TryParse(trimmedValue, out result))
                    return result/100;
                else
                    return value;
            }

            if (targetType == typeof (decimal))
            {
                decimal result;
                if (decimal.TryParse(trimmedValue, out result))
                    return result/100;
                else
                    return value;
            }
            return value;
        }

        #endregion
    }
}