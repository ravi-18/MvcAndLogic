using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPS_NetDeveloperProgrammingSkillTest
{
    public class AlphabetD
    {
        public AlphabetD(int n) 
        {
            Resolve(n);
        }

        private static void Resolve(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                if (i % 5 == 0 && i != 5) Console.Write("IDIC ");
                else if (i % 6 == 0 && i != 6) Console.Write("LPS ");
                else Console.Write(i + " ");
            }
        }
    }
}
