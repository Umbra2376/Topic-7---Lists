using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            bool task1 = false;
            bool task2 = false;
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
                    }
                    while (task1 == false)
                    {
                        Console.Clear();
                        for (int i = 0; i < numbers.Count; i++)
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
                        Console.WriteLine("Please select 1-10 now");
                        int response = Convert.ToInt32(Console.ReadLine());
                        if (response == 1)
                        {
                            numbers.Sort();
                            Console.WriteLine("The list has been sorted.");
                        }
                        else if (response == 2)
                        {
                            numbers.Clear();
                            for (int j = 0; j < 25; j++)
                            {
                                numbers.Add(randnum.Next(1, 21));
                                Console.Write(numbers[j] + ", ");
                            }
                            Console.WriteLine("A new list has been created.");
                        }
                        else if (response == 3)
                        {
                            Console.WriteLine("Enter a number to remove:");
                            int numToRemove = Convert.ToInt32(Console.ReadLine());
                            numbers.RemoveAll(x => x == numToRemove);
                            Console.WriteLine($"All occurrences of {numToRemove} have been removed.");
                        }
                        else if (response == 4)
                        {
                            Console.WriteLine("Enter a value to add to the list:");
                            int valueToAdd = Convert.ToInt32(Console.ReadLine());
                            numbers.Add(valueToAdd);
                            Console.WriteLine($"{valueToAdd} has been added to the list.");
                        }
                        else if (response == 5)
                        {
                            Console.WriteLine("Enter a number to count occurrences:");
                            int numToCount = Convert.ToInt32(Console.ReadLine());
                            int count = numbers.Count(x => x == numToCount);
                            Console.WriteLine($"The number {numToCount} occurs {count} times in the list.");
                        }
                        else if (response == 6)
                        {
                            int maxValue = numbers.Max();
                            Console.WriteLine($"The largest value in the list is {maxValue}.");
                        }
                        else if (response == 7)
                        {
                            int minValue = numbers.Min();
                            Console.WriteLine($"The smallest value in the list is {minValue}.");
                        }
                        else if (response == 8)
                        {
                            int sum = numbers.Sum();
                            double average = numbers.Average();
                            Console.WriteLine($"The sum of the list is {sum} and the average is {average}.");
                        }
                        else if (response == 9)
                        {
                            var mostFrequent = numbers.GroupBy(x => x)
                                                      .OrderByDescending(g => g.Count())
                                                      .Select(g => g.Key)
                                                      .First();
                            Console.WriteLine($"The most frequently occurring number is {mostFrequent}.");
                        }
                        else if (response == 10)
                        {
                            task1 = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice, press ENTER to continue.");
                            Console.ReadLine();
                        }
                        Console.WriteLine("Hit ENTER to continue.");
                        Console.ReadLine();
                    }
                }
                else if (choice == "2")
                {
                    // Do option 2
                    List<string> vegetables = new List<string>();
                    vegetables.Add("CARROT");
                    vegetables.Add("BROCCOLI");
                    vegetables.Add("SPINACH");
                    vegetables.Add("KALE");
                    vegetables.Add("PEAS");
                    for (int i = 0; i < vegetables.Count; i++)
                    {
                        Console.WriteLine("1. " + vegetables[i]);
                    }
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