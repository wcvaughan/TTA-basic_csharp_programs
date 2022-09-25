using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {

        //List<string> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Jesse");
        //intList.Remove("Jesse");


        //Console.WriteLine(intList[0]);
        //Console.ReadLine();


        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
        //Console.WriteLine(numArray1[3]);

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        //Console.WriteLine(numArray2);

        //numArray2[5] = 650;
        //Console.WriteLine(numArray2[5]);

        //Console.WriteLine(numArray[3]);
        //Console.ReadLine();

        //Create a one - dimensional Array of strings.Ask the user to select an index of the Array and then display the string at that index on the screen.
        string[] stringArray1 = new string[] { "Work it", "Make it", "Do it", "Makes us", "Harder", "Better", "Faster", "Stronger" };
        Console.WriteLine("Select a number, any number.");
        int userPick = Convert.ToInt32(Console.ReadLine());
        switch(userPick)
        {
            case 0:
                Console.WriteLine(stringArray1[userPick]);
                break;
            case 1:
                Console.WriteLine(stringArray1[userPick]);
                break;
            case 2:
                Console.WriteLine(stringArray1[userPick]);
                break;
            case 3:
                Console.WriteLine(stringArray1[userPick]);
                break;
            case 4:
                Console.WriteLine(stringArray1[userPick]);
                break;
            case 5:
                Console.WriteLine(stringArray1[userPick]);
                break;
            case 6:
                Console.WriteLine(stringArray1[userPick]);
                break;
            case 7:
                Console.WriteLine(stringArray1[userPick]);
                break;
            default:
                Console.WriteLine("Pick a number between 0-7.");
                break;
        }
        Console.ReadLine();
        //Create a one - dimensional Array of integers.Ask the user to select an index of the Array and then display the integer at that index on the screen.
        int[] numArray4 = { 42, 24, 52, 128, 64 };
        Console.WriteLine("Pick another new number, this time pretty much stick to numbers 0-4");
        int usersPick = Convert.ToInt32(Console.ReadLine());
        switch (usersPick)
        {
            case 0:
                Console.WriteLine(numArray4[usersPick]);
                break;
            case 1:
                Console.WriteLine(numArray4[usersPick]);
                break;
            case 2:
                Console.WriteLine(numArray4[usersPick]);
                break;
            case 3:
                Console.WriteLine(numArray4[usersPick]);
                break;
            default:
                Console.WriteLine("Pick a number between 0-4.");
                break;
        }
        // Add in a message that displays when the user selects an index that doesn’t exist.

        //Create a list of strings.Ask the user to select an index of the list and then display the content at that index on the screen.
        List<string> nameList = new List<string>();
        nameList.Add("Terrence");
        nameList.Add("Platy Platypus");
        nameList.Add("Perton");
        nameList.Add("Fairan");
        nameList.Add("Coyn");
        Console.WriteLine("Now we've made a list and you ought to pick something from it (0-4)");
        int userGuess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(nameList[userGuess]);
        Console.ReadLine();
        //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.


    }
}

