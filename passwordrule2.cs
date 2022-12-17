using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User19
{
    public class passwordrule2
    {
        public static string regexrule = ("^[A-Z]{1,8}[a-z0-9]{7,}$");
        public bool validatePassWord2(string inputstring)
        {
            return Regex.IsMatch(inputstring, regexrule);
        }
    }
}