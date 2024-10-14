using System;

class Program
{
    public static MorzeCodeClass translator;
    public static string shortSymbol;
    public static string longSymbol;
    public static void SymbolInput()
    {
        Console.Write("Add a new short symbol: ");
        shortSymbol = Console.ReadLine();
        Console.Write("Add a new long symbol: ");
        longSymbol = Console.ReadLine();

        if (shortSymbol.Length == 1 && longSymbol.Length == 1 && shortSymbol != longSymbol)
        {
            translator = new MorzeCodeClass(shortSymbol, longSymbol);
            translator.SymbolChanges();
        }
        else
        {
            throw new Exception("Wrong Input!");
        }
    }

    static void Main(string[] args)
    {
        translator = new MorzeCodeClass(shortSymbol, longSymbol);
        bool menu = true;
        
        while (menu)
        {
            Console.Clear();
            Console.WriteLine("Welcome the Morze Translator Console Application!");
            Console.WriteLine();
            Console.WriteLine("[1.] Morze to Text");
            Console.WriteLine("[2.] Text to Morze");
            Console.WriteLine("[3.] Change short and long symbols");
            Console.WriteLine("[4.] Exit");
            Console.WriteLine();
            string choice = Console.ReadLine();

            switch (choice) 
            {
                case "1":
                    Console.WriteLine();
                    Console.Write("Add a morze code: ");
                    string morze = Console.ReadLine();
                    string decodedMessage = translator.Decode(morze);
                    Console.WriteLine($"Original text: {decodedMessage}");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine();
                    Console.Write("Add a text: ");
                    string text = Console.ReadLine();
                    string encodedMessage = translator.Encode(text.ToUpper());
                    Console.WriteLine($"Original text: {encodedMessage}");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine();
                    SymbolInput();
                    break;
                case "4":
                    Console.WriteLine();
                    Console.WriteLine("Continue? [y/n]");
                    string cont = Console.ReadLine();
                    if (cont == "y")
                    {
                        continue;
                    }
                    else
                    {
                        menu = false;
                    }
                    break;
            }
        }
    }
}
