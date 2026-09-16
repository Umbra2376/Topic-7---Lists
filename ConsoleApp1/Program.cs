using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Welcome to my lists menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Task 1");
                Console.WriteLine("2 - Task 2");
                Console.WriteLine("...");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    //Do option 1
                    Random randnum = new Random();
                    List<int> numbers = new List<int>();
                    for (int i = 0; i < 25; i++)
                    {
                        numbers.Add(randnum.Next(1, 21));
                        Console.Write(numbers[i] + ", ");
                        Console.WriteLine("Now you may select what to do with this list.");
                        Console.WriteLine("1 - Sort the list");
                        Console.WriteLine("2 - Make a new list");
                        Console.WriteLine("3 - Remove all occurences of a number");
                        Console.WriteLine("4 - Add a value to the list");
                        Console.WriteLine("5 - Count the number of occurences of a number");
                        Console.WriteLine("6 - Print the largest value");
                        Console.WriteLine("7 - Print the smallest value");
                        Console.WriteLine("8 - Print the SUM and average value");
                        Console.WriteLine("9 - Determine the most frequntly occuring number");
                        Console.WriteLine("10 - Quit");
                    }
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                // Add an else if for each valid choice...
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
    }
}