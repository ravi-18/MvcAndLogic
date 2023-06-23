using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPS_NetDeveloperProgrammingSkillTest
{
    public class Utility
    {
        /*Convert string array to number array
         * with convensional method*/
        public static int[] ConvertToIntArray(string inputString, string tanda)
        {
            string[] arrayString = inputString.Split(tanda);
            int[] arrayInt = new int[arrayString.Length];

            for (int i = 0; i < arrayString.Length; i++)
            {
                arrayInt[i] = int.Parse(arrayString[i]);
            }
            return arrayInt;
        }
    }
}
