using System;
using System.Collections.Generic;
using static System.Console;

namespace ItemCombiner
{
    class Program
    {
        

        static void Main()
        {
            WriteLine("start");
            ReadKey(true);
            Deposit();
            
        }

        static List<string> Inventory = new List<string>();
        static string input = " ";
        static void Deposit()
        {
            Inventory.Add("Banana");
            Inventory.Add("Knife");
            Inventory.Add("Banana");
            Inventory.Add("Knife");
            Inventory.Add("Banana");
            Inventory.Add("Knife");
            Inventory.Add("Banana");
            Inventory.Add("Knife");

            ListInventory();

            while (Inventory.Contains("Knife") && Inventory.Contains("Banana"))
            {
                WriteLine("Do you want to cut this banana?");
                input = ReadLine().ToLower();

                if(input.StartsWith("y"))
                {
                    Inventory.Remove("Banana");
                    Inventory.Remove("Knife");
                    Inventory.Add("Sliced Banana");
                }
                else
                {
                    WriteLine("You spared the banana");
                    break;
                }
                
            }


            ListInventory();
            ReadKey(true);
        }

        static void ListInventory()
        {
            WriteLine("You now posses");
            foreach (var item in Inventory)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
