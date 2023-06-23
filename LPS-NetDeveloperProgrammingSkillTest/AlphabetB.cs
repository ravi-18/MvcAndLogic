using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPS_NetDeveloperProgrammingSkillTest
{
    public class AlphabetB
    {
        public AlphabetB(string angka)
        {
            Resolve(angka);
        }

        public static void Resolve(string angka)
        {
            if (!string.IsNullOrEmpty(angka))
            {
                char[] arrChar = angka.ToCharArray();

                var newCharArr = arrChar.Where(e => !e.Equals('.')).ToArray();
            
                string[] resString = new string[newCharArr.Length];

                for (int i = 0; i < newCharArr.Length; i++)
                {
                    resString[i] = newCharArr[i].ToString();
                    for(int j = 0; j < newCharArr.Length-1-i; j++)
                    {
                        if(newCharArr[i] != '0')
                        {
                            resString[i] += "0";
                        }
                    }
                }
                foreach(var i in resString) Console.WriteLine(i);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("angka tidak di isi");
                Console.WriteLine();

            }
        }
    }
}
