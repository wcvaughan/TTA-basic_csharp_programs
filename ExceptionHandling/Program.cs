using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing hte two...");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //    Console.ReadLine();

            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number.");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by zero.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}
            //Console.ReadLine();

            //Create a list of integers.Ask the user for a number to divide each number in the list by.Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
            //List<int> numbers = new List<int>();

            //numbers.Add(25);
            //numbers.Add(27);
            //numbers.Add(29);
            //numbers.Add(31);
            //numbers.Add(33);
            //numbers.Add(35);

            //Console.WriteLine("Give me a number!");
            //int userNumber = Convert.ToInt32(Console.ReadLine());

            //foreach (int number in numbers)
            //    {
            //        Console.WriteLine(number / userNumber);
            //    }
        //Run the code, entering in non - zero numbers as the user.Look at the displayed results.
        //Run the code again, entering in zero as the number to divide by.Note any error messages you get.
        //Run the code once again, entering in a string as the number to divide by.Note any error messages you get.
        //Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.In the catch block, display the error message to the screen.Then try various combinations of user input: valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
        try
        {
            List<int> numbers = new List<int>();

            numbers.Add(25);
            numbers.Add(27);
            numbers.Add(29);
            numbers.Add(31);
            numbers.Add(33);
            numbers.Add(35);

            Console.WriteLine("Give me a number!");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            foreach (int number in numbers)
            {
                Console.WriteLine(number / userNumber);
            }

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Don't give me a zero!");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please give me a whole number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("We have exited the try/catch block! The program continues");
        }
        Console.ReadLine();
            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

        }
    }
