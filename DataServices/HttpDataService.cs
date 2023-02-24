
namespace DIAPI.DataServices
{
    public class HttpDataService : IDataService
    {
        public string GetProductData(string url)
        {
            //throw new NotImplementedException();
            Console.ForegroundColor =  ConsoleColor.Yellow;
            Console.WriteLine("---> Getting Product data....");
            Console.ResetColor();

            return ("Some product Data....");
        }
    }
}