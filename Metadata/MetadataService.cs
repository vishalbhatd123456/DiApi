
namespace DIAPI.MetadataService
{
    public class MetadataService : IMetadataService
    {
        private readonly IMetadataService _metadataService;

        private MetadataService(IMetadataService metadataService)
        {
            _metadataService = metadataService;
        }
        public string GetMetaDataDetails(string url)
        {
            Console.ForegroundColor =  ConsoleColor.Green;
            Console.WriteLine("---> Getting Meta data....");
            Console.ResetColor();
            return ("Some Meta Data....");
        }
        public string ReturnData()
        {
            _metadataService.GetMetaDataDetails("https://getsomemetadata.com");
            return ("succesful metadata returned");
        }
    }
}