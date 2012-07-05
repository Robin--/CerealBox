﻿using System.Text.RegularExpressions;

namespace CerealBox
{
    public static class StringExtensions
    {
        public static string FlattenXml(this string input)
        {
            input = Regex.Replace(input, "(\r|\n)", string.Empty);
            input = Regex.Replace(input, @">\s*<", "><").Trim();
            return input;
        }
    }
}
