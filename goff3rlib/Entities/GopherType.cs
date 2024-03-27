using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goff3rlib.Entities
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

    public sealed class GopherType
    {
        public const char GopherFile = '0';
        public const char GopherDirectory = '1';
        public const char GopherCSOPhoneBookServer = '2';
        public const char GopherError = '3';
        public const char GopherBixHexedMacintoshFile = '4';
        public const char GopherDOSBinaryArchive = '5';
        public const char GopherUNIXuuencodedFile = '6';
        public const char GopherIndexSearchServer = '7';
        public const char GopherToTelnetSessionPointer = '8';
        public const char GopherBinaryFile = '9';
        public const char GopherRedundantServer = '+';
        public const char GopherTN3270Session = 'T';
        public const char GopherGIFfile = 'g';
        public const char GopherImageFile = 'I';
    }
}
