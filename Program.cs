using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothSentence
{
    class Program
    {
        public static string sentence;
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Hello World---\n");
            while (true)
            {
                Console.WriteLine("\n========================================");
                Console.WriteLine("Write a Smooth Sentence");
                Console.WriteLine("========================================\n");

                sentence = Console.ReadLine();
                IsSmooth(sentence);
            }
            Console.ReadKey();
        }

        static async Task IsSmooth(string sentence)
        {
            sentence = sentence.Trim().ToLower();
            string[] sentences = sentence.Split(' '); 

            if (sentence.Length <= 1)
            {
                Console.WriteLine("\nIts not a 'Sentence'!");
            }

            for (int i = 0; i < sentences.Length - 1; i++)
            {
                string previousWord = sentences[i];
                char lastChar = Char.Parse(previousWord.Substring(previousWord.Length - 1));

                string followingWord = sentences[i + 1];
                char firstChar = Char.Parse(followingWord.Substring(0, 1));

                if (lastChar != firstChar)
                {
                    Console.WriteLine("\nIts not a 'Smooth Sentence'!");
                   goto end;
                }
                else
                {
                    Console.WriteLine("\nIts a 'Smooth Sentence'!");
                }
            }
            end:
                ;
        }
    }
}
