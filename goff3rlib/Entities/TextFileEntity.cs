using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace goff3rlib.Entities;

public class TextFileEntity
{
    public string Text { get; private set; }

    public TextFileEntity()
    {
        Text = "";
    }

    public static TextFileEntity Parse(string input)
    {
        TextFileEntity textFile = new TextFileEntity();

        string[] lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
        foreach (string line in lines)
        {
            string parsedLine = line;
            if (parsedLine.StartsWith("."))
            {
                // If the line starts with a period, prepend an extra period
                parsedLine = "." + parsedLine;
            }
            textFile.Text += parsedLine + Environment.NewLine;
        }

        return textFile;
    }

    public override string ToString()
    {
        return Text.TrimEnd() + ".";
    }
}

