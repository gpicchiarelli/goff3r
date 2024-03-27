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

using System.Runtime.CompilerServices;
using static goff3rlib.Entities.GopherType;

namespace goff3rlib.Entities
{

    public sealed class DirectoryEntity
    {
        private const string Gopher_CRLF = "\r\n";
        private const string Gopher_TAB = "\t";
        private const string Gopher_Lastline = "." + Gopher_CRLF;
        private const char Gopher_NUL = '\0';
        private Uri GopherHost = null;
        private int port = 70;
        private const char GopherTypeChar = GopherType.GopherDirectory;

        private DirectoryEntity()
        {

        }

        private string ToString() { return string.Empty; }
    }
}
