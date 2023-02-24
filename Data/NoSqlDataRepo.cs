
using DIAPI.DataServices;

namespace DIAPI.Data
{
    public class NoSqlDataRepo : IDataRepo
    {
        private readonly IDataService _dataService;

        public NoSqlDataRepo(IDataService dataService)
        {
            _dataService = dataService;
        }
        public string GetData(){
            //remove if unrequired
            return ("Not used");
        }
        public string ReturnData()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> Getting data from NoSql Database...");
            _dataService.GetProductData("https://somethingwascalled.com");
            Console.ResetColor();
            return ("NoSql Data from Db");
        }
    }
}