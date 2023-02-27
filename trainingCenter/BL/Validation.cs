using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace trainingCenter.BL
{
    internal class Validation
    {
        public static bool validateNameInArabic(string name)
        {
            if (string.IsNullOrEmpty(name)|| name=="")
            {
                return false;
            }
            else if (!Regex.IsMatch(name, @"^[\u0621-\u064A_ ]+$"))

            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
