using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenates three strings.
            Console.WriteLine("Tell me a story.");
            string partOne = Console.ReadLine();
            Console.WriteLine("Keep going.");
            string partTwo = Console.ReadLine();
            Console.WriteLine("Now bring it home, tuck me into bed.");
            string partThree = Console.ReadLine();
            string theWhole = partOne + partTwo + partThree;
            Console.WriteLine(theWhole);
            //Converts a string to uppercase.
            Console.WriteLine("Now I'm going to yell it back at you.");
            Console.WriteLine(theWhole.ToUpper());
            //Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();
            string lineOne = "One midnight clear in starlight still";
            string lineTwo = "I dreamed I received this bill";
            string lineThree = "Five thousand breathless dawns all new";
            string lineFour = "Five thousand roses wet with dew";
            string lineFive = "Ten thousand ice flakes served ice cold";
            string lineSix = "Five thousand sunsets wrapped in gold";
            string lineSeven = "Five quiet friends";
            string lineEight = "One baby's love";
            sb.AppendLine(lineOne);
            sb.AppendLine(lineTwo);
            sb.AppendLine(lineThree);
            sb.AppendLine(lineFour);
            sb.AppendLine(lineFive);
            sb.AppendLine(lineSix);
            sb.AppendLine(lineSeven);
            sb.AppendLine(lineEight);
            Console.WriteLine(sb);
            Console.ReadLine();
            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
        }
    }
}
