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
    internal sealed class DirectoryEntity
    {
        /*
           0   Item is a file
           1   Item is a directory
           2   Item is a CSO phone-book server
           3   Error
           4   Item is a BinHexed Macintosh file.
           5   Item is DOS binary archive of some sort.
               Client must read until the TCP connection closes.  Beware.
           6   Item is a UNIX uuencoded file.
           7   Item is an Index-Search server.
           8   Item points to a text-based telnet session.
           9   Item is a binary file!
        */
        public enum Type {  
                            GopherFile = 0,
                            GopherDirectory = 1,
                            GopherCSOPhoneBookServer = 2,
                            GopherError = 3,
                            GopherBixHexedMacintoshFile = 4,
                            GopherDOSBinaryArchive = 5,
                            GopherUNIXuuencodedFile = 6,
                            GopherIndexSearchServer = 7,
                            GopherToTelnetSessionPointer= 8,
                            GopherBinaryFile = 9
                        }

        private readonly string CRLF = "\r\n";
        private readonly string TAB = "\t";
        private readonly string Lastline = string.Empty;
        private readonly string NUL = "\0";

        private DirectoryEntity()
        {
            Lastline = string.Concat('.', CRLF);
        }

        private string ToString() { return string.Empty; }
    }
}
