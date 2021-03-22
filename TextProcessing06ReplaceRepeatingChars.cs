using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextProcessing06
{
    class Program
    {

        static void Main()
        {
            //TextProcessing06ReplaceRepeatingChars

            StringBuilder charBuilder = new StringBuilder();

            string text = Console.ReadLine();
            charBuilder.Append(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != charBuilder[charBuilder.Length-1])
                {
                    charBuilder.Append(text[i]);
                }
            }


            Console.WriteLine(charBuilder);


            //
        }
    }
}