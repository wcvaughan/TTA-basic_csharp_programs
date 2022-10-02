using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step251ConsoleAppIterationsListsArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            ////A one-dimensional array of strings.
            string[] itHurts = { "head", "shoulders", "knees", "toes" };
            ////Ask the user to input some text.
            Console.WriteLine("Where does it hurt?");
            string userResponse = Console.ReadLine();
            ////A loop that iterates through each string in the array and adds the user's text input to the end of each string. This step will not output anything to the console, but will update each array element by appending the user's text.
            for (int i = 0; i < itHurts.Length; i++)
            {
                itHurts[i] = itHurts[i] + " " + userResponse;
            }
            ////Then create a second loop that prints off each string in the array one at a time.
            for (int i = 0; i < itHurts.Length; i++)
            {
                Console.WriteLine(itHurts[i]);
            }

            ////An infinite loop. Fixed by changing the middle condition of i in the for loop. Previous it was "i > 0" and changing it to "100 > i" gave it an end point.
            int A = 10;
            for (int i = 1; 100 > i; i++)
            {
                Console.WriteLine(i + A);
            }

            ////A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            int[] numArray = { 5, 4, 3, 2, 1 };
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
            ////Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(numArray[i]);
            }

            //A list of strings where each item in the list is unique.
            string[] novels = { "Foundation", "Hyperion", "Otherland", "Disc World" };

            ////Ask the user to input text to search for in the list.
            Console.WriteLine("Guess one of my favorite books!");
            string userGuess = Console.ReadLine();
            ////A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.

            ////Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.

            ////Add code that stops the loop from executing once a match has been found.
            //// This was try #1, but it seemed they were prompting me to use a switch block.
            //for (int i = 0; i < novels.Length; i++)
            //{
            //    userGuess = novels[i];
            //    Console.WriteLine("I love that book! It's my #" + Array.IndexOf(novels, userGuess));
            //    if (userGuess != novels[i])
            //    {
            //        Console.WriteLine("That's not one of my favorite books.");
            //    }
            //}


            ////I'll need to use a switch case loop for this exercise.
            ////A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.

            ////Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.

            ////Add code that stops the loop from executing once a match has been found.
            switch (userGuess)
            {
                case "Foundation":
                    Console.WriteLine("That's my #" + (Array.IndexOf(novels, userGuess) + 1) + " favorite book!");
                    break;
                case "Hyperion":
                    Console.WriteLine("That's my #" + (Array.IndexOf(novels, userGuess) + 1) + " favorite book!");
                    break;
                case "Otherland":
                    Console.WriteLine("That's my #" + (Array.IndexOf(novels, userGuess) + 1) + " favorite book!");
                    break;
                case "Disc World":
                    Console.WriteLine("That's my #" + (Array.IndexOf(novels, userGuess) + 1) + " favorite book!");
                    break;
                default:
                    Console.WriteLine("That's not one of my favorites");
                    break;
            }

            ////A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            List<string> oneOfTheseThings = new List<string>();

            oneOfTheseThings.Add("Boisonberry");
            oneOfTheseThings.Add("Blueberry");
            oneOfTheseThings.Add("Strawberry");
            oneOfTheseThings.Add("Raspberry");
            oneOfTheseThings.Add("Blueberry");

            Console.WriteLine("What kind of berry is in my smoothie? Answer carefully Mr. Bond, your life depends on it");
            string bondGuess = Console.ReadLine();
            ////Create a loop that iterates through the list and then displays the indices of the items matching the user - selected text. Ensure to remove any break statements that may prevent your code from returning multiple matches.
            switch (bondGuess)
            {
                case "Boisonberry":
                    Console.WriteLine("This is the #" + (oneOfTheseThings.IndexOf(bondGuess) + 1) + "guess I suspected");
                    break;
                case "Strawberry":
                    Console.WriteLine("This is the #" + (oneOfTheseThings.IndexOf(bondGuess) + 1) + "guess I suspected");
                    break;
                case "Raspberry":
                    Console.WriteLine("This is the #" + (oneOfTheseThings.IndexOf(bondGuess) + 1) + "guess I suspected");
                    break;
                case "Blueberry":
                    Console.WriteLine("This is the #" + (oneOfTheseThings.IndexOf(bondGuess) + 1) + "guess I suspected");
                    Console.WriteLine("This is the #" + (oneOfTheseThings.LastIndexOf(bondGuess) + 1) + "guess I suspected");
                    break;
                default:
                    Console.WriteLine("Not that one Mr. Bond");
                    break;
            }
            //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list. (You do not need to provide any additional chances for the user to enter text.)


            //Create a list of strings that has at least two identical strings in the list
            List<string> kalimat = new List<string>();

            kalimat.Add("kitaab");
            kalimat.Add("kutub");
            kalimat.Add("kaatib");
            kalimat.Add("kutub");
            kalimat.Add("maktab");
            kalimat.Add("kutub");

            //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            foreach(string kalam in kalimat)
            {
                Console.WriteLine(kalam);
                if (kalimat.IndexOf(kalam) + kalimat.IndexOf(kalam) > kalimat.Count())
                {
                    Console.WriteLine("\n" +"This item has appeared already");
                }
            }
            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.


            Console.ReadLine();

        }
    }
}
