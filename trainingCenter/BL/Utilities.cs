using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace trainingCenter.BL
{
    internal static class Utilities
    {
        public static bool validateNameInArabic(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 3 || !Regex.IsMatch(name, @"^[\u0621-\u064A_ ]+$"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static bool ValidatPhoneNumber(string phoneNumber)
        {

            if (string.IsNullOrEmpty(phoneNumber) || (!Regex.IsMatch(phoneNumber, @"^01[0125][0-9]{8}$")))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool checkDropDownList(object obj)
        {
            if (obj != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static bool checkDoubleNumber(string s)
        {
            if (double.TryParse(s,out double x))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

