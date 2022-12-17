using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User19
{
    public class passwordrule3
    {
        public static string regexrule = "^[A-Za-z]{6,}[A-Z]{1}[0-9]{1,}$";
        public bool validatePassWord3(string inputstring)
        {
            return Regex.IsMatch(inputstring, regexrule);
        }
    }
}