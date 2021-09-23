using DataAccessLibrary;

namespace BusinessLogicLayer
{
    public class DatabaseBLL
    {
        public bool BackUp(string Path, string Name)
        {
            return new DatabaseDAL().BackUp(Path, Name);
        }
        public bool RestoreBackUp(string Path, string Name)
        {
            return new DatabaseDAL().RestoreBackUp(Path, Name);
        }
    }
}