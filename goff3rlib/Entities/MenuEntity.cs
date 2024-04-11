using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using goff3rlib.Entities;

namespace goff3rlib.Entities;

public class MenuEntity
{
    public List<DirEntity> Directories { get; private set; }

    public MenuEntity()
    {
        Directories = new List<DirEntity>();
    }

    public static MenuEntity Parse(string input)
    {
        MenuEntity menu = new MenuEntity();

        string[] lines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string line in lines)
        {
            if (line == ".")
            {
                // Lastline encountered, stop parsing
                break;
            }

            DirEntity dirEntity = DirEntity.Parse(line);
            menu.Directories.Add(dirEntity);
        }

        return menu;
    }

    public override string ToString()
    {
        string result = "";
        foreach (DirEntity dirEntity in Directories)
        {
            result += dirEntity.ToString() + Environment.NewLine;
        }
        result += ".";
        return result;
    }
}
