using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyCSharpPractice.Core.Experiments
{
    public partial class Experiment
    {
        public static string DatesAndStrings(DateTime date)
        {
            return date.ToString("MM/dd/yyyy hh:mm:ss.fff tt");
        }

        public static string DatesAndStrings24Hour(DateTime date)
        {
            return date.ToString("MM/dd/yyyy HH:mm:ss.fff");
        }

        public static string DatesAndStrings24HourYearFirst(DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
    }
}
