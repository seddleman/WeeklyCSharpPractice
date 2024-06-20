using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyCSharpPractice.Core.Experiments
{
    public partial class Experiment
    {
        public static bool ReferencePassChange(MyObject obj, decimal x)
        {
            obj.IsHidden = true;
            obj.UpdatedValue = x;
            return true;
        }

        public static decimal ReferencePassAdd(MyObject obj, decimal x)
        {
            obj.IsHidden = true;
            obj.UpdatedValue = obj.Value + x;
            return obj.Value;
        }
    }

    public class MyObject
    {
        public string Name { get; set; } = string.Empty;
        public int Number { get; set; }
        public bool IsHidden { get; set; }
        public decimal Value { get; set; }
        public decimal UpdatedValue { get; set; }
    }
}
