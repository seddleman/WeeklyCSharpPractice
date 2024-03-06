using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyCSharpPractice.Core.TestDome
{
    public partial class Dome
    {

        public static string FirstUniqueProduct(string[] products)
        {

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string word in products)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word] += 1;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            return dictionary.First(x => x.Value == 1).Key.ToString();
        }
    }
}
