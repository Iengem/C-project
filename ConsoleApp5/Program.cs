using System;
using System.Collections.Generic;
using System.Globalization;

public class MarketProgram
{
    static void Market()
    {
        Console.WriteLine("Welcome to Iengem's Market");
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("\n");

        var items = new Dictionary<string, int>();
        TextInfo currentText = CultureInfo.CurrentCulture.TextInfo;
        bool option = true;
        do
        {
            Console.WriteLine("Enter an item you want to buy");
            string item = Console.ReadLine().ToLower().Trim();

            if (items.ContainsKey(item))
            {
                items[item] += 1;
            }
            else
            {
                items.Add(item, 1);

            }

            Console.WriteLine("Do you want to enter more?(Y or N)");
            string choice = Console.ReadLine();
            string choiceLowered = choice.ToLower();
            option = choiceLowered[0] == 'y' ? true : false;
            if (!option)
            {
                Console.WriteLine("The items you have selected are:");
                foreach (KeyValuePair<string, int> item1 in items)
                {
                    Console.WriteLine(currentText.ToTitleCase($"{item1.Key}: {item1.Value}"));
                }
            }

        } while (option);
    }

    static void Main(string[] args)
    {
        Market();
    }
}
