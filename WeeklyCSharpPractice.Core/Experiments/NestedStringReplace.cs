using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyCSharpPractice.Core.Experiments
{
    public partial class Experiment
    {
        public static string NestedStringReplace(int number)
        {
        //    var template = "GMTzx:00";
            return "GMTzx:00".Replace('z', number < 0 ? '-' : '+').Replace("x", Math.Abs(number).ToString());
        }
    }
}
