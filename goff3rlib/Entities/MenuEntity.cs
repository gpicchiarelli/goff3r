using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*
 Menu Entity

Menu      ::= {DirEntity} Lastline.
 */

namespace goff3rlib.Entities
{
    public class MenuEntity
    {
        private List<DirectoryEntity> menuItems = null;
        private const string Gopher_CRLF = "\r\n";
        private const string Gopher_Lastline = "." + Gopher_CRLF;

        public MenuEntity(string raw) 
        {
            if (!raw.Contains(Gopher_Lastline)) 
            {
                throw new Exception("Menu - wrong format - lastline Missing");
            }
        }

        public string ToString() { return String.Empty; }
    }
}
