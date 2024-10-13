using System;

class Program
{
    static void Main(string[] args)
    {
        MorzeCodeClass translator = new MorzeCodeClass();

        Console.Write("Add a morze code: ");
        string morze = Console.ReadLine();
        string convertedMessage = translator.Convert(morze);
        Console.WriteLine($"Original text: {convertedMessage}");
    }
}
