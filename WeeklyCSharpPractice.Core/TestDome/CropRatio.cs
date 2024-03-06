using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyCSharpPractice.Core.TestDome
{
    public partial class Dome
    {
        private int totalWeight;
        private Dictionary<string, int> crops = new Dictionary<string, int>();

        public void AddCrop(string name, int cropWeight)
        {
            int currentCropWeight;
            crops.TryGetValue(name, out currentCropWeight);  // get value if exists.

            if (currentCropWeight == 0) crops[name] = 0;  // Seed the dictionary
            
            crops[name] += cropWeight;
            totalWeight += cropWeight;
        }

        public double CropRatioProportion(string name)
        {
            if (crops.ContainsKey(name)) return (double)crops[name] / totalWeight;

            return 0;
        }
    }
}
