using System;

namespace LPS_NetDeveloperProgrammingSkillTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "Y";

            while (answer.ToLower() == "y")
            {
                Console.WriteLine("B, C, D, E");
                Console.WriteLine();
                Console.Write("Enter the case alphabet: ");
                string caseAlphabet = Console.ReadLine();

                switch (caseAlphabet.ToUpper())
                {
                    /*
                        Ada inputan angka seperti ini :
                        1.225.441
                        Berikan outputnya berupa :
                        1000000
                        200000
                        20000
                        5000
                        400
                        40
                        1
                     */
                    case "B":
                        Console.Write("Masukan nominal : ");
                        string nominal = Console.ReadLine();
                        AlphabetB nomor1 = new AlphabetB(nominal);
                        break;
                    
                     /*
                        Ada inputan string sebagai berikut :
                        hello world
                        Berikan outputnya berupa :
                        h – 1
                        e – 1
                        l – 3
                        o – 2
                        w – 1
                        r – 1
                        d – 1
                     */
                    case "C":
                        Console.Write("Masukan word : ");
                        string word = Console.ReadLine();
                        AlphabetC nomor2 = new AlphabetC(word);
                        break;

                    /*
                        Buatlah program console application berupa pengulangan angka dari 1 sampai dengan
                        inputan N. Jika angkanya kelipatan 5 dan angkanya bukan 5 tulis “IDIC”. Jika kelipatan 6
                        dan bukan angka 6 tulis “LPS”.
                        Contoh : 1 2 3 4 5 6 7 8 9 IDIC 11 LPS 13 14 IDIC 16 17 LPS 19 dst.. . . N
                     */
                    case "D":
                        Console.Write("Masukan nilai n : ");
                        int n = int.Parse(Console.ReadLine());
                        AlphabetD nomor3 = new AlphabetD(n);
                        break;

                    /*
                        Buatlah sebuah program sederhana untuk menghasil kan output penulisan huruf Kapital
                        menggunakan console application C# seperti contoh berikut ini :
                        Input :
                        SeLamAT PAGi semua halOo
                        Output :
                        Format Judul: Selamat Pagi Semua Haloo
                        Format Biasa: Selamat pagi semua haloo
                     */
                    case "E":
                        Console.Write("Masukan sempel kalimat : ");
                        var words = Console.ReadLine();
                        AlphabetE nomor4 = new AlphabetE(words);
                        break;

                    default:
                        Console.WriteLine("No you exsist");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to continue?");
                answer = Console.ReadLine();

                Console.Clear();
            }
        }
    }
}