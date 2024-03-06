using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyCSharpPractice.Core.TestDome
{
    public partial class Dome
    {
        public static string FindCommonNames(string[] names1, string[] names2)
        {
            HashSet<String> result = new HashSet<String>();
            foreach (string name in names1) result.Add(name);
            foreach (string name in names2) result.Add(name);

            String[] ret = new String[result.Count];
            result.CopyTo(ret);
            return string.Join(", ", ret);
        }

        
    }
}
