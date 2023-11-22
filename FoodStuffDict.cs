using System;

static void Market()
{
    Console.WriteLine("Welcome to Iengem's Market");
    Console.WriteLine();
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("\n");

    var items = Dictionary<string, int>();
    bool option = true;
    do
    {
        Console.WriteLine("Enter an item you want to buy");
        string item = Console.ReadLine();
        Dictionary.Add(item, 0);
        if (items.ContainsKey(item))
        {
            items[item] += 1;
        }
        Console.WriteLine("Do you want to enter more?(Y or N)");
        string choice = Console.ReadLine();
        string choiceLowered = choice.ToLower();
        option = choiceLowered == 'y' ? true : false;
        if(option == false)
        {
            foreach (KeyValuePair<string, int> item in items)
            {
                Console.WriteLine(item.Key + ", " item.Value);
            }
        }
        
    }while option
}


private static void main()
{
    Market();
}
