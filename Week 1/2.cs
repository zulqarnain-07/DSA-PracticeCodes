using System;

//Write a C# program that utilizes a 1D array to implement a simple inventory management system 

class Program
{
    static void Main()
    {
        string[] inventory = new string[10];
        int item = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Inventory Management ---");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Search Item");
            Console.WriteLine("4. View Inventory");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": 
                    if (item < inventory.Length)
                    {
                        Console.Write("Enter item name: ");
                        string addItem = Console.ReadLine();
                        inventory[item] = addItem;
                        item++;
                        Console.WriteLine($"{addItem} added to inventory.");
                    }
                    else
                    {
                        Console.WriteLine("Inventory is full!");
                    }
                    break;

                case "2": 
                    Console.Write("Enter item name to remove: ");
                    string removeItem = Console.ReadLine();
                    bool foundForRemoving = false;

                    for (int i = 0; i < item; i++)
                    {
                        if (inventory[i] == removeItem)
                        {
                            for (int j = i; j < item - 1; j++)
                            {
                                inventory[j] = inventory[j + 1];
                            }
                            inventory[item - 1] = null;
                            item--;
                            foundForRemoving = true;
                            Console.WriteLine($"{removeItem} removed.");
                            break;
                        }
                    }

                    if (!foundForRemoving)
                    {
                        Console.WriteLine("Item not found.");
                    }
                    break;

                case "3": 
                    Console.Write("Enter name to search: ");
                    string search = Console.ReadLine();
                    bool found = false;

                    foreach (var i in inventory)
                    {
                        if (i == search)
                        {
                            found = true;
                            break;
                        }
                    }

                    if (found)
                        Console.WriteLine("Item found.");
                    else
                        Console.WriteLine("Item not found.");
                    break;

                case "4": 
                    Console.WriteLine("Current Inventory:");
                    if (item == 0)
                    {
                        Console.WriteLine("Inventory is empty.");
                    }
                    else
                    {
                        for (int i = 0; i < item; i++)
                        {
                            Console.WriteLine($"{i + 1}. {inventory[i]}");
                        }
                    }
                    break;

                case "5": 
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}
