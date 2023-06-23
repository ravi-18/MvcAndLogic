namespace LPS_NetDeveloperProgrammingSkillTest
{
    public class AlphabetE
    {
        public AlphabetE(string? words)
        {
            Resolve(words);
        }
        
        private static void Resolve(string? words)
        {
            string[] arrstr = words.ToLower().Split(" ");

            Console.Write("Format Judul : ");
            for (var i = 0; i < arrstr.Length; i++)
            {
                var word = arrstr[i].ToCharArray();
                var result1 = "";
                for(var j = 0; j < word.Length; j++)
                {
                    if (j == 0) result1 += word[j].ToString().ToUpper();
                    else result1 += word[j];
                } 
                Console.Write(result1 + " ");
            }

            Console.WriteLine();

            Console.Write("Format Biasa : ");

            for (var i = 0; i < arrstr.Length; i++)
            {
                var word = arrstr[i].ToCharArray();
                var result1 = "";
                if (i == 0)
                {
                    for (var j = 0; j < word.Length; j++)
                    {
                        if (j == 0) result1 += word[j].ToString().ToUpper();
                        else result1 += word[j];
                    }
                }
                else result1 = arrstr[i];
                Console.Write(result1 + " ");
            }
            Console.WriteLine();
        }
    }
}