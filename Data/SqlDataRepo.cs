using DIAPI.Data;

namespace DIApi.Data
{
    public class SqlDataRepo : IDataRepo
    {
        public string ReturnData()
        {
            Console.ForegroundColor = ConsoleColor.Blue;  
            Console.WriteLine("--> Getting data from sql database...");
            Console.ResetColor();

            return ("Got SQL Data from DB...");
        }
    }
}