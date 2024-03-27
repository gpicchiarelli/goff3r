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
        private const char GopherRedundantServer = '+';
        private const char GopherTN3270Session = 'T';
        private const char GopherGIFfile = 'g';
        private const char GopherImageFile = 'I';
    }
}
