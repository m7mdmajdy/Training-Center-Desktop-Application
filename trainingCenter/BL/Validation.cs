using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace courseCenter.BL
{
    internal class Validation
    {
        public static bool validateName(string name)
        {
            if (name == null) { throw new ArgumentNullException("name is Empty"); }

                else
                {
                    string pattern = "^[\u0621-\u064A]+$";
                    Regex rg = new Regex(pattern);
                if (rg.IsMatch(name)){
                    return true;
                }
                else
                {
                    return false;
                }
                }
        }
    }
}
