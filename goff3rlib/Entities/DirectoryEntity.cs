/*
 Directory Entity

CR-LF     ::= ASCII Carriage Return Character followed by Line Feed
              character.

Tab       ::= ASCII Tab character.

NUL       ::= ASCII NUL character.

UNASCII   ::= ASCII - [Tab CR-LF NUL].

Lastline  ::= '.'CR-LF.

TextBlock ::= Block of ASCII text not containing Lastline pattern.

Type      ::= UNASCII.

RedType   ::= '+'.

User_Name ::= {UNASCII}.

Selector  ::= {UNASCII}.

Host      ::= {{UNASCII - ['.']} '.'} {UNASCII - ['.']}.

Note: This is a Fully Qualified Domain Name as defined in RFC 1034.
      (e.g., gopher.micro.umn.edu)  Hosts that have a CR-LF
      TAB or NUL in their name get what they deserve.

Digit     ::= '0' | '1' | '2' | '3' | '4' | '5' | '6' | '7' | '8' | '9' .

DigitSeq  ::= digit {digit}.

Port      ::= DigitSeq.
 */

namespace goff3rlib.Entities
{

    public sealed class DirectoryEntity
    {
        private const string Gopher_CRLF = "\r\n";
        private const string Gopher_TAB = "\t";
        private const string Gopher_Lastline = "." + Gopher_CRLF;
        private const char Gopher_NUL = '\0';
        private readonly Uri? GopherHost = null;
        private readonly int port = 70;
        private const char GopherTypeChar = GopherType.GopherDirectory;
        private readonly string Selector = string.Empty; //255 chars
        private readonly string User_Name = string.Empty; //69 chars

        private DirectoryEntity(string selector, string user_Name, Uri Host, int port = 70)
        {
            Selector = selector[..254];
            User_Name = user_Name[..69];
            GopherHost = Host;
            //Type User_Name Tab Selector Tab Host Tab Port CR-LF
        }

        private string ToString()
        {
            return GopherTypeChar + User_Name + Gopher_TAB + Selector + Gopher_TAB + GopherHost + Gopher_TAB + port + Gopher_CRLF;
        }
    }
}
