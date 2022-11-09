namespace HW4NMcAndrew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to CustomList Homework!");
            Console.Write("Specify the initial capacity of the list: ");
            //Ask if this is against coding standards
            CustomList<string> list = new CustomList<string>(int.Parse(Console.ReadLine()));
            
            string userInput = "";
            int index = 0;
            while (userInput != "done")
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Enter a word: ");
                userInput = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();
                switch(userInput)
                {
                    case "done":
                        Console.WriteLine("Goodbye!");
                        break;

                    case "print":
                        Console.WriteLine("Printing the list:");
                        list.Print();
                        break;

                    case "indexof":
                        Console.Write("Word to search for: ");
                        userInput = Console.ReadLine();
                        if (list.Contains(userInput))
                        {
                            Console.WriteLine($"{userInput}");
                        }

                        else
                        {
                            Console.WriteLine($"{userInput}is at index {list.IndexOf(userInput)} (it does not exist)");
                        }
                        //In case user searches for "done"
                        userInput = "";
                            break;

                    case "contains":
                        Console.Write("Word to search for: ");
                        userInput = Console.ReadLine();
                        if (list.Contains(userInput))
                        {
                            Console.WriteLine($"{userInput} IS in the list");
                        }
                        else 
                        {
                            Console.WriteLine($"{userInput} is NOT in the list");
                        }
                        userInput = "";
                        break;

                    case "removeat":
                        Console.Write("Which index to remove: ");
                        userInput = Console.ReadLine();
                        index = int.Parse(userInput);
                        if (list.IndexIsValid(index))
                        {
                            list.RemoveAt(index);
                            Console.WriteLine($"Data at index {userInput} has been removed");

                        }
                        else
                        {
                            Console.WriteLine($"{userInput} is not a valid index");
                        }
                        break;

                    case "remove":
                        Console.Write("Word to remove: ");
                        userInput = Console.ReadLine();
                        if (list.Contains(userInput))
                        {
                            list.Remove(userInput);
                            Console.WriteLine($"\"{userInput}\" was removed");
                        }
                        else 
                        {
                            Console.WriteLine($"\"{userInput}\" was not found");
                        }
                        userInput = "";
                        break;

                    case "insert":
                        Console.Write("Word to insert: ");
                        userInput= Console.ReadLine();
                        Console.Write("Which index: ");
                        index = int.Parse(Console.ReadLine());
                        if (list.IndexIsValid(index))
                        {
                            list.Insert(index, userInput);
                            Console.WriteLine($"{userInput} inserted at index {index}");
                        }
                        else
                        {
                            Console.WriteLine($"{index} is not a valid index");
                        }
                        break;

                    case "clear":
                        Console.WriteLine("List has been cleared");
                        list.Clear();
                        break;

                    case "get":
                        Console.Write("What index: ");
                        index = int.Parse(Console.ReadLine());
                        if (list.Count > index)
                        {
                            Console.WriteLine($"Word at {index} is: {list[index]}");
                        }
                        else 
                        {
                            Console.WriteLine($"{index} is not a valid index");
                        }
                        break;

                    case "set":
                        Console.Write("What index: ");
                        index = int.Parse(Console.ReadLine());
                        Console.Write("New word: ");
                        userInput = Console.ReadLine();
                        if (list.IndexIsValid(index))
                        {
                            list[index] = userInput;
                            Console.WriteLine($"Word at {index} is: {list[index]}");
                        }
                        else
                        {
                            Console.WriteLine($"{index} is not a valid index");
                        }
                        userInput = "";
                        break;

                    //adds word to the list
                    default:
                        list.Add(userInput);
                        Console.WriteLine($"{userInput} has been added to the list");
                        break;
                }
            }



            //Showing functionality with ints:
            Console.WriteLine();
            Console.WriteLine("Integer List:");
            CustomList<int> intList = new CustomList<int>();
            intList.Add(0);
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);

            Console.WriteLine();
            Console.WriteLine("Added 0, 1, 2, 3, and 4 to the list");         
            Console.WriteLine("Printing:");
            intList.Print();

            Console.WriteLine();
            Console.WriteLine("Removing 4 and index 0: ");
            intList.Remove(4);
            intList.RemoveAt(0);
            intList.Print();

            Console.WriteLine();
            Console.WriteLine("Adding 5 and inserting 98 at index 2:");
            intList.Add(5);
            intList.Insert(2, 98);
            intList.Print();

            Console.WriteLine();
            Console.WriteLine($"Contains 98 is {intList.Contains(98)}");
            Console.WriteLine($"Contains 65 is {intList.Contains(65)}");

            Console.WriteLine();
            Console.WriteLine($"The index of 98 is {intList.IndexOf(98)}");

            Console.WriteLine();
            Console.WriteLine($"Getting index 0: {intList[0]}");
            Console.WriteLine("Changing the index:");
            intList[0] = 42;
            Console.WriteLine($"{intList[0]} is now at index 0");

            Console.WriteLine();
            Console.WriteLine("List will be cleared:");
            Console.WriteLine("Before:");
            intList.Print();
            intList.Clear();
            Console.WriteLine("After:");
            intList.Print();
        }
    }
}