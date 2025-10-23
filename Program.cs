namespace Topic_7___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<int> nums = new List<int>();

            for (int i = 0; i <= 25; i++)
            {
                nums.Add(generator.Next(10, 21));
            }


            string choice = "";
            string choiceNum = "";
            int number;

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Welcome to my Lists Menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - List of Numbers");
                Console.WriteLine("2 - Menu Option 2");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    //Do option 1
                    Console.WriteLine("You chose List of Numbers");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    while (choiceNum != "q")
                    {
                        int removedNums = 0;
                        int countedNums = 0;
                        Console.WriteLine("Here is the list of numbers:");
                        for (int i = 0; i < (nums.Count); i++)
                        {
                            Console.Write(nums[i] + " ");
                        }
                        Console.WriteLine();
                        Console.WriteLine("What would you like to do with this list of numbers?:");
                        Console.WriteLine();
                        Console.WriteLine("1 - Sort");
                        Console.WriteLine("2 - Generate New List");
                        Console.WriteLine("3 - Remove a Number");
                        Console.WriteLine("4 - Add a Number");
                        Console.WriteLine("5 - Count the Numbers");
                        Console.WriteLine("6 - Largest Number");
                        Console.WriteLine("7 - Smallest Number");
                        Console.WriteLine("8 - Sum and Average");
                        Console.WriteLine("9 - Most Frequently Occuring Value");
                        Console.WriteLine("Q - Quit");
                        Console.WriteLine();
                        choiceNum = Console.ReadLine().ToLower().Trim();
                        Console.WriteLine();
                        Console.Clear();

                        if (choiceNum == "1")
                        {
                            Console.WriteLine("You chose Sort");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            nums.Sort();
                            Console.WriteLine("The numbers were sorted");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (choiceNum == "2")
                        {
                            Console.WriteLine("You chose Generate New List");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            nums.Clear();
                            for (int i = 0; i <= 25; i++)
                            {
                                nums.Add(generator.Next(10, 21));
                            }
                            Console.WriteLine("The numbers were regenerated");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (choiceNum == "3")
                        {
                            Console.WriteLine("You chose Remove a Number");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            Console.WriteLine("What number would you like to remove?");
                            while (!Int32.TryParse(Console.ReadLine(), out number)) 
                            {
                                Console.WriteLine("What number would you like to remove?");
                            }
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] == number)
                                {
                                    nums.RemoveAt(i);
                                    i -= 1;
                                    removedNums += 1;
                                }
                            }
                            Console.WriteLine($"{removedNums} {number}'s were removed");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (choiceNum == "4")
                        {
                            Console.WriteLine("You chose Add a Number");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            Console.WriteLine("What number would you like to add?");
                            while (!Int32.TryParse(Console.ReadLine(), out number))
                            {
                                Console.WriteLine("What number would you like to add?");
                            }
                            nums.Add(number);
                            Console.WriteLine($"{number} was added to the list");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (choiceNum == "5")
                        {
                            Console.WriteLine("You chose Count the Numbers");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            Console.WriteLine("What number would you like to count?");
                            while (!Int32.TryParse(Console.ReadLine(), out number))
                            {
                                Console.WriteLine("What number would you like to count?");
                            }
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] == number)
                                {
                                    countedNums += 1;
                                }
                            }
                            Console.WriteLine($"There are {countedNums} {number}'s in the list");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (choiceNum == "6")
                        {
                            Console.WriteLine("You chose Largest Number");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            int max = nums[0];
                            for (int i = 1; i < nums.Count; i++)
                            {
                                if (nums[i] > max)
                                {
                                    max = nums[i];
                                }
                            }
                            Console.WriteLine($"The largest number is {max}");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (choiceNum == "7")
                        {
                            Console.WriteLine("You chose Smallest Number");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            int min = nums[0];
                            for (int i = 1; i < nums.Count; i++)
                            {
                                if (nums[i] < min)
                                {
                                    min = nums[i];
                                }
                            }
                            Console.WriteLine($"The smallest number is {min}");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (choiceNum == "8")
                        {
                            Console.WriteLine("You chose Sum and Average");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                        }
                        else if (choiceNum == "9")
                        {
                            Console.WriteLine("You chose Most Frequently Occuring Value");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                        }
                        else if (choiceNum == "q")
                        {
                            Console.WriteLine("You chose Quit");
                            Console.WriteLine("Hit ENTER to continue.");
                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine("Invalid choice, press ENTER to continue.");
                            Console.ReadLine();
                        }
                    }
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
