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
               Client must read until the TCP connection closes.  Beware.
           +   Item is a redundant server
           T   Item points to a text-based tn3270 session.
           g   Item is a GIF format graphics file.
           I   Item is some kind of image file.  Client decides how to display.

        */

       private const char GopherFile = '0';
       private const char GopherDirectory = '1';
       private const char GopherCSOPhoneBookServer = '2';
       private const char GopherError = '3';
       private const char GopherBixHexedMacintoshFile = '4';
       private const char GopherDOSBinaryArchive = '5';
       private const char GopherUNIXuuencodedFile = '6';
       private const char GopherIndexSearchServer = '7';
       private const char GopherToTelnetSessionPointer = '8';
       private const char GopherBinaryFile = '9';
       private const string Gopher_CRLF = "\r\n";
       private const string Gopher_TAB = "\t";
       private const string Gopher_Lastline = "." + Gopher_CRLF;
       private const char Gopher_NUL = '\0';
       private const char GopherRedundantServer = '+';
       private const char GopherTN3270Session = 'T';
       private const char GopherGIFfile = 'g';
       private const char GopherImageFile = 'I';


        private DirectoryEntity()
        {

        }

        private string ToString() { return string.Empty; }
    }
}
