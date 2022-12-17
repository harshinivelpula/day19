using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User19
{
    public class mobileformat
    {
        public static string regexrule = ("[1-9][0-9][ ]?[6-9][0-9]{9}$");
        public bool validatemobilenumber(string inputstring)
        {
            return Regex.IsMatch(inputstring, regexrule);
        }
    }
}
