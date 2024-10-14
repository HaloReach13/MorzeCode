using System;
using System.Collections.Generic;
using System.Text;

public class MorzeCodeClass
{
    public Dictionary<char, string> morzeToText { get; set; } 

    public string shortSymbol;

    public string longSymbol;

    public MorzeCodeClass(string ShortSymbol, string LongSymbol)
    {
        this.shortSymbol = ShortSymbol;
        this.longSymbol = LongSymbol;
        Dictionary();
    }

    public void Dictionary()
    {
        string[] file = File.ReadAllLines("morze.txt");
        morzeToText = new Dictionary<char, string>();
        foreach (var item in file)
        {
            string[] split = item.Split(";");
            morzeToText.Add(char.Parse(split[0]), split[1]);
        }
    }

    public void SymbolChanges()
    {
        foreach (var item in morzeToText)
        {
            morzeToText[item.Key] = item.Value.Replace(".", shortSymbol).Replace("-", longSymbol);
        }
    }

    public string Decode(string morseCode)
    {
        StringBuilder convertedMessage = new StringBuilder();
        string[] letters = morseCode.Split(' ');
        foreach (var item in letters)
        {
            if (morzeToText.ContainsValue(item))
            {
                
                convertedMessage.Append(morzeToText.FirstOrDefault(s => s.Value == item).Key);
            }
            else
            {
                convertedMessage.Append('?');
            }
        }
        convertedMessage.Append(' ');
        return convertedMessage.ToString().Trim();
    }

    public string Encode(string text)
    {
        StringBuilder convertMessage = new StringBuilder();
        foreach (var item in text) 
        {
            if (morzeToText.ContainsKey(item))
            {
                convertMessage.Append(morzeToText[item]);
            }
            else
            {
                convertMessage.Append('?');
            }
        }
        convertMessage.Append(' ');
        return convertMessage.ToString().Trim();
    }
}
