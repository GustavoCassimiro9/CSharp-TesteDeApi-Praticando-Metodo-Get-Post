using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace AutomacaoAltoroJRestAPI
{
    public class CustomConfigurationProvider
    {
        private static string GetPath()
        {
            var osdelimiter = RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ? "/" : "\\";

            string path = string.Empty;
#if (TestEnv)
            path = $"{Directory.GetCurrentDirectory()}{osdelimiter}Data{osdelimiter}TestEnv{osdelimiter}";

#else
            path = $"{Directory.GetCurrentDirectory()}{osdelimiter}Data{osdelimiter}";
#endif
            return path;
        }

        private static IConfiguration configuration { get; set; }
        static CustomConfigurationProvider()
        {
            var builder = new ConfigurationBuilder().
                                 SetBasePath(GetPath()).AddJsonFile("AltoroJRestApiTestData.json");

            configuration = builder.Build();
        }


        public static T GetSection<T>(string key) where T : class
        {
            if (configuration != null)
            {
                T objInstance = Activator.CreateInstance<T>();
                configuration.GetSection(key).Bind(objInstance);
                T actualObject = objInstance; return actualObject;
            }
            return null;
        }
        /// <summary>
        /// use .(DOT) to get GetSection
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSection(string key)
        {
            var obj = JObject.Parse(File.ReadAllText($@"{GetPath()}AltoroJRestApiTestData.json"));
            var val = obj.SelectToken(key).ToString();
            return val;
        }



        /// <summary>
        /// use :(colon) to get Key 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetKey(string key)
        {
            if (key == "AltoroJRestApi-baseUrl")
            {
#if (TestEnv)
key = "petStoreService-baseUrl";
#endif
            }

            string value = null;
            if (configuration != null)
            {
                value = configuration[key];
                if (value == null)
                {
                    throw new Exception($"Could not find the key {key} in AltoroJRestApiTestData.json file");
                }
            }
            return value;
        }
    }
}
