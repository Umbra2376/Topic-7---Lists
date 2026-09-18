using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
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
                    int task1Choice, numToRemove, numToAdd, numToCount;
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
                        string response = Console.ReadLine();
                        if (!int.TryParse(response, out task1Choice))
                        {
                            Console.WriteLine("This is an invalid option, please try again");
                        }
                        else if (task1Choice == 1)
                        {
                            numbers.Sort();
                            Console.WriteLine("The list has been sorted.");
                        }
                        else if (task1Choice == 2)
                        {
                            numbers.Clear();
                            for (int j = 0; j < 25; j++)
                            {
                                numbers.Add(randnum.Next(1, 21));
                                Console.Write(numbers[j] + ", ");
                            }
                            Console.WriteLine("A new list has been created.");
                        }
                        else if (task1Choice == 3)
                        {
                            Console.WriteLine("Enter a number to remove:");
                            while (!int.TryParse(Console.ReadLine(), out numToRemove) && !numbers.Contains(numToRemove))
                            {
                                Console.WriteLine("This is invalid please try again.");
                            }
                            numbers.RemoveAll(x => x == numToRemove);
                            Console.WriteLine($"All occurrences of {numToRemove} have been removed.");
                        }
                        else if (task1Choice == 4)
                        {
                            Console.WriteLine("Enter a value to add to the list:");
                            while (!int.TryParse(Console.ReadLine(), out numToAdd))
                            {
                                Console.WriteLine("This is invalid please try again.");
                            }
                            numbers.Add(numToAdd);
                            Console.WriteLine($"{numToAdd} has been added to the list.");
                        }
                        else if (task1Choice == 5)
                        {
                            Console.WriteLine("Enter a number to count occurrences:");
                            while (!int.TryParse(Console.ReadLine(), out numToCount) && !numbers.Contains(numToCount))
                            {
                                Console.WriteLine("This is invalid please try again.");
                            }
                            int count = numbers.Count(x => x == numToCount);
                            Console.WriteLine($"The number {numToCount} occurs {count} times in the list.");
                        }
                        else if (task1Choice == 6)
                        {
                            int maxValue = numbers.Max();
                            Console.WriteLine($"The largest value in the list is {maxValue}.");
                        }
                        else if (task1Choice == 7)
                        {
                            int minValue = numbers.Min();
                            Console.WriteLine($"The smallest value in the list is {minValue}.");
                        }
                        else if (task1Choice == 8)
                        {
                            int sum = numbers.Sum();
                            double average = numbers.Average();
                            Console.WriteLine($"The sum of the list is {sum} and the average is {average}.");
                        }
                        else if (task1Choice == 9)
                        {
                            var mostFrequent = numbers.GroupBy(x => x)
                                                      .OrderByDescending(g => g.Count())
                                                      .Select(g => g.Key)
                                                      .First();
                            Console.WriteLine($"The most frequently occurring number is {mostFrequent}.");
                        }
                        else if (task1Choice == 10)
                        {
                            task1 = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice.");
                        }
                        Console.WriteLine("Hit ENTER to continue.");
                        Console.ReadLine();
                    }
                }
                else if (choice == "2")
                {
                    // Do option 2
                    int index, task2Choice;
                    List<string> vegetables = new List<string>();
                    vegetables.Add("CARROT");
                    vegetables.Add("BROCCOLI");
                    vegetables.Add("SPINACH");
                    vegetables.Add("KALE");
                    vegetables.Add("PEAS");
                    while (task2 == false)
                    {
                        for (int i = 0; i < vegetables.Count; i++)
                        {
                            Console.WriteLine(i + ". " + vegetables[i]);
                        }
                        Console.WriteLine("Now you may choose what to do with this list of vegetables.");
                        Console.WriteLine("1 - Remove a vegetable by index");
                        Console.WriteLine("2 - Remove a vegetable by it's name");
                        Console.WriteLine("3 - Search a vegetable's index");
                        Console.WriteLine("4 - Add a vegetable to the list");
                        Console.WriteLine("5 - Quit");
                        string option = Console.ReadLine();
                        if (!int.TryParse(option, out task2Choice))
                        {
                            Console.WriteLine("This is an invalid option, please try again");
                            Console.WriteLine("Press ENTER to continue.");
                            Console.ReadLine();
                        }
                        else if (task2Choice == 1)
                        {
                            Console.WriteLine("PLease type the index of the vegetable you would like to remove");
                            while (!int.TryParse(Console.ReadLine(), out index) && index > vegetables.Count && index < 0)
                                Console.WriteLine("Please enter a valid number!");
                            vegetables.RemoveAt((int)index);
                        }
                        else if (task2Choice == 2)
                        {
                            Console.WriteLine("Please type the name of the vegetable you would like to remove");
                            string name = Console.ReadLine().ToUpper();
                            if (vegetables.Contains(name))
                            {
                                vegetables.Remove(name);
                                Console.WriteLine("I have removed " + name + " from the list.");
                            }
                            else
                                Console.WriteLine("The list doesn't contain this vegetable.");
                        }
                        else if (task2Choice == 3)
                        {
                            Console.WriteLine("Please type in which vegetable you would like to search for.");
                            string search = Console.ReadLine().ToUpper();
                            if (vegetables.Contains(search))
                            {
                                int searchIndex = vegetables.BinarySearch(search);
                                Console.WriteLine($"The index of {search} is {searchIndex}.");
                            }
                            else
                            {
                                Console.WriteLine("Could not find this vegetable.");
                            }
                        }
                        else if (task2Choice == 5)
                        {
                            task2 = true;
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