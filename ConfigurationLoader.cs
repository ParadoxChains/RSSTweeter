using System;

namespace RSSTweeter
{
    class ConfigurationLoader
    {
        private string[] loadedFile;

        public ConfigurationLoader()
        {
            loadedFile = System.IO.File.ReadAllLines("config.txt");
            foreach(string x in loadedFile)
            {
                Console.WriteLine(x);
            }
        }

        public string getAPIKey()
        {
            return loadedFile[1];
        }

        public string getAPISecretKey()
        {
            return loadedFile[3];
        }

        public string getBearerToken()
        {
            return loadedFile[5];
        }

        public string getAccessToken()
        {
            return loadedFile[7];
        }

        public string getAccessTokenSecret()
        {
            return loadedFile[9];
        }
    }
}
