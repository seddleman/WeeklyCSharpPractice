using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyCSharpPractice.Core.Experiments
{
    public partial class Experiment
    {
        public static string GetEnumLabel(ExperimentEnum value)
        {
            return value.ToString();
        }
    }

    public enum ExperimentEnum
    {
        NoChange = 0,
        LittleChange = 1,
        SomeChange = 2,
        BigChange = 3
    }
}
