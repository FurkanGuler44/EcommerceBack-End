namespace Ecommerce.Context
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Ecommerce"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("DefaultSqlConnectionString");
            }
        }
    }
}
