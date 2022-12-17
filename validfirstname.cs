using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User19
{
    public class validfirstname
    {
        public static string regexrule = (@"^[A-Z]{1}[A-Za-z]{2,}?$");
        public bool validatefirstname(string inputstring)
        {
            return Regex.IsMatch(inputstring, regexrule);
        }
    }
}