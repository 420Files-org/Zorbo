﻿using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using System.Windows.Data;

using Zorbo.Core.Interfaces;

namespace Zorbo.Server.WPF.Converters
{
    /// <summary>
    /// Used for DataBinding an Avatar to display it's byte size in numerical units.
    /// </summary>
    public class AvatarToSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {

            if (value is IAvatar avatar)
                return avatar.SmallBytes.Length;

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return null;   
        }
    }
}