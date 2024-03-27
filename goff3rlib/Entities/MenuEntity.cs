/*
 Menu Entity

Menu      ::= {DirEntity} Lastline.
 */

namespace goff3rlib.Entities
{
    public class MenuEntity
    {
        private readonly List<DirectoryEntity>? menuItems = null;
        private const string Gopher_CRLF = "\r\n";
        private const string Gopher_Lastline = "." + Gopher_CRLF;

        public MenuEntity(string raw)
        {
            if (!raw.Contains(Gopher_Lastline))
            {
                throw new Exception("Menu - wrong format - lastline Missing");
            }
            else
            {
                try
                {

                }
                catch (Exception) { throw; }
            }
        }

        public string ToString() { return string.Empty; }
    }
}
