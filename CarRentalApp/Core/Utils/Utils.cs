﻿using System;

namespace CarRentalApp.Core.Utils
{
    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }
    }
    public static class Utils
    {

    }
}
