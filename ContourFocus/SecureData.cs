using Microsoft.Extensions.Configuration;

namespace ContourFocus
{
    public static class SecureData
    {
        public static string Get(string keyWord)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(CurrentDirectory.Get());
            builder.AddJsonFile("appConfig.json");
            var config = builder.Build();

            return config.GetConnectionString(keyWord);
        }
    }

    public static class CurrentDirectory
    {
        public static string Get()
        {
            var startDirectory = new DirectoryInfo(Directory.GetCurrentDirectory())
                .Parent;

            var i = 0;
            string currentDirectory = "";
            do
            {
                if (startDirectory != null)
                {
                    i++;
                    currentDirectory = startDirectory.FullName;
                    startDirectory = startDirectory.Parent;
                }
            }
            while (i < 3);

            return currentDirectory;
        }
    }
}
