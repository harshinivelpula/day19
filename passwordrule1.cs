using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User19
{
    public class passwordrule1
    {
        public static string regexrule = "[A-Za-z0-9]{8,}";
        public bool validatePassWord1(string inputstring)
        {
            return Regex.IsMatch(inputstring, regexrule);
        }
    }
}