
namespace DIAPI.Data
{
    public class NoSqlDataRepo : IDataRepo
    {
        public string GetData(){
            //remove if unrequired
            return ("Not used");
        }
        public string ReturnData()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> Getting data from NoSql Database...");
            Console.ResetColor();

            return ("NoSql Data from Db");
        }
    }
}