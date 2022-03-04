namespace Catalog.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string ConnectionString
        {
            get
            {
                var a = $"mongodb://{Host}:{Port}";

                return a;
            }
        }
    }
}