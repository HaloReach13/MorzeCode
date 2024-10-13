using System;

class Program
{
    public static MorzeCodeClass translator;
    public static void SymbolInput()
    {
        Console.Write("Add a short symbol: ");
        string shortSymbol = Console.ReadLine();
        Console.Write("Add a long symbol: ");
        string longSymbol = Console.ReadLine();

        if (shortSymbol.Length == 1 && longSymbol.Length == 1 && shortSymbol != longSymbol)
        {
            translator = new MorzeCodeClass(shortSymbol, longSymbol);
        }
        else
        {
            throw new Exception("Wrong Input!");
        }
    }

    static void Main(string[] args)
    {
        SymbolInput();
        bool menu = true;
        while (menu)
        {
            Console.Clear();
            Console.WriteLine("1. Morze to Text");
            Console.WriteLine("2. Text to Morze");
            Console.WriteLine("3. Exit");
            string choice = Console.ReadLine();

            switch (choice) 
            {
                case "1":
                    Console.Write("Add a morze code: ");
                    string morze = Console.ReadLine();
                    string decodedMessage = translator.Decode(morze);
                    Console.WriteLine($"Original text: {decodedMessage}");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Add a text: ");
                    string text = Console.ReadLine();
                    string encodedMessage = translator.Encode(text.ToUpper());
                    Console.WriteLine($"Original text: {encodedMessage}");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Continue? [y/n]");
                    string cont = Console.ReadLine();
                    if (cont == "y")
                    {
                        menu = false;
                    }
                    else
                    {
                        continue;
                    }
                    break;
            }
        }
    }
}
