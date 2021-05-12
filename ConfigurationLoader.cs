using System;

namespace RSSTweeter
{
    class ConfigurationLoader
    {
        private string[] loadedFile;

        public ConfigurationLoader()
        {
            loadedFile = System.IO.File.ReadAllLines("config.txt");
            /*
             * Configuration file must be named "config.txt" and placed in
             * same directory as the .exe file.
             * The expected format of the file is as follows:
             * -----------------------------------------------------------
             * API Key
             * $TWITTER_API_KEY$
             * API Secret Key
             * $TWITTER_API_SECRET_KEY$
             * Bearer Token
             * $TWITTER_BEARER_TOKEN$
             * Access Token
             * $TWITTER_ACCESS_TOKEN$
             * Access Token Secret
             * $TWITTER_ACCESS_TOKEN_SECRET$
             * -----------------------------------------------------------
             */
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
