using System;

namespace p133practica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Isdifadeci trefinden cumle daxil olunur.
            //Daxil Olunan Cumlenin Sozleri Oz Sirasinda Qalmaqla Tersine Cevrilir.
            //Misal: Salam Qrup Uzvler-- > malaS purQ relvzU Method Seklinde Yazirsiniz
            Console.WriteLine("Cumle daxil edin ");
            string sentence = Console.ReadLine();
            string[] words  = sentence.Split(" ");
            string tersCumle = "";
            for (int i = 0; i < words.Length; i++)
            {
               char[] characters = words[i].ToCharArray();
                for (int j = characters.Length -1; j >=0; j--)
                {
                    Console.Write(characters[j]);
                }
                Console.Write(" ");
            }

            Console.ReadKey();
        }
    }
}
