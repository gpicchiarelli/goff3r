using System;
using System.Text.RegularExpressions;
namespace goff3rlib.Entities;

public class DirEntity
{
    public string Type { get; set; }
    public string UserName { get; set; }
    public string Selector { get; set; }
    public string Host { get; set; }
    public int Port { get; set; }

    public DirEntity(string type, string userName, string selector, string host, int port)
    {
        Type = type;
        UserName = userName;
        Selector = selector;
        Host = host;
        Port = port;
    }

    public static DirEntity Parse(string input)
    {
        string pattern = @"(?<Type>[\w\+\-]+)\t(?<UserName>[^\t]+)\t(?<Selector>[^\t]+)\t(?<Host>[^\t]+)\t(?<Port>\d+)";
        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            string type = match.Groups["Type"].Value;
            string userName = match.Groups["UserName"].Value;
            string selector = match.Groups["Selector"].Value;
            string host = match.Groups["Host"].Value;
            int port = int.Parse(match.Groups["Port"].Value);

            return new DirEntity(type, userName, selector, host, port);
        }
        else
        {
            throw new FormatException("Input string does not match the expected format.");
        }
    }

    public override string ToString()
    {
        return $"{Type}\t{UserName}\t{Selector}\t{Host}\t{Port}";
    }
}