using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPS_NetDeveloperProgrammingSkillTest
{
    public class AlphabetC
    {
        public AlphabetC(string huruf) 
        {
            Resolve(huruf);
        }

        private static void Resolve(string huruf)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            foreach (char c in huruf)
            {
                if (char.IsLetter(c))
                {
                    if (characterCount.ContainsKey(c))
                    {
                        characterCount[c]++;
                    }
                    else
                    {
                        characterCount[c] = 1;
                    }
                }
            }
            foreach(var c in characterCount)
            {
                Console.WriteLine(c.Key  + " = " + c.Value);
            }
        }
        
    }
}
