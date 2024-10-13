using System;
using System.Collections.Generic;
using System.Text;

public class MorzeCodeClass
{
    public Dictionary<string, char> morzeToText;
    public string dotSymbol { get; set; }
    public string dashSymbol { get; set; }

    public MorzeCodeClass()
    {
        dotSymbol = ".";
        dashSymbol = "-";
        Dictionary();
    }

    public void Dictionary()
    {
        morzeToText = new Dictionary<string, char>
        {
            { $"{dotSymbol}{dashSymbol}", 'A' },
            { $"{dashSymbol}{dotSymbol}{dotSymbol}{dotSymbol}", 'B' },
            { $"{dashSymbol}{dotSymbol}{dashSymbol}{dotSymbol}", 'C' },
            { $"{dashSymbol}{dotSymbol}{dotSymbol}", 'D' },
            { $"{dotSymbol}", 'E' },
            { $"{dotSymbol}{dotSymbol}{dashSymbol}{dotSymbol}", 'F' },
            { $"{dashSymbol}{dashSymbol}{dotSymbol}", 'G' },
            { $"{dotSymbol}{dotSymbol}{dotSymbol}{dotSymbol}", 'H' },
            { $"{dotSymbol}{dotSymbol}", 'I' },
            { $"{dotSymbol}{dashSymbol}{dashSymbol}{dashSymbol}", 'J' },
            { $"{dashSymbol}{dotSymbol}{dashSymbol}", 'K' },
            { $"{dotSymbol}{dashSymbol}{dotSymbol}{dotSymbol}", 'L' },
            { $"{dashSymbol}{dashSymbol}", 'M' },
            { $"{dashSymbol}{dotSymbol}", 'N' },
            { $"{dashSymbol}{dashSymbol}{dashSymbol}", 'O' },
            { $"{dotSymbol}{dashSymbol}{dashSymbol}{dotSymbol}", 'P' },
            { $"{dashSymbol}{dashSymbol}{dotSymbol}{dashSymbol}", 'Q' },
            { $"{dotSymbol}{dashSymbol}{dotSymbol}", 'R' },
            { $"{dotSymbol}{dotSymbol}{dotSymbol}", 'S' },
            { $"{dashSymbol}", 'T' },
            { $"{dotSymbol}{dotSymbol}{dashSymbol}", 'U' },
            { $"{dotSymbol}{dotSymbol}{dotSymbol}{dashSymbol}", 'V' },
            { $"{dotSymbol}{dashSymbol}{dashSymbol}", 'W' },
            { $"{dashSymbol}{dotSymbol}{dotSymbol}{dashSymbol}", 'X' },
            { $"{dashSymbol}{dotSymbol}{dashSymbol}{dashSymbol}", 'Y' },
            { $"{dashSymbol}{dashSymbol}{dotSymbol}{dotSymbol}", 'Z' }
        };
    }

    public string Convert(string morseCode)
    {
        StringBuilder convertedMessage = new StringBuilder();
        string[] words = morseCode.Split(" / ");
        foreach (var item in words)
        {
            string[] letters = item.Split(' ');
            foreach (var item2 in letters)
            {
                if (morzeToText.ContainsKey(item2))
                {
                    convertedMessage.Append(morzeToText[item2]);
                }
                else
                {
                    convertedMessage.Append('?');
                }
            }
            convertedMessage.Append(' ');
        }
        return convertedMessage.ToString().Trim();
    }
}
