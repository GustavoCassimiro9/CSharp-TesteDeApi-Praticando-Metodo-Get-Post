using AutomacaoAltoroJRestAPI;
namespace AutomacaoAltoroJRestAPI.Helpers
{
    public class APIMethods
    {
        public static string Geral
        {
            get { return $"{CustomConfigurationProvider.GetKey("AltoroJRestApi-baseUrl")}"; }
        }
        public static string Login
        {
            get { return $"{CustomConfigurationProvider.GetKey("AltoroJRestApi-baseUrl")}login"; }
        }
        public static string Account
        {
            get { return $"{CustomConfigurationProvider.GetKey("AltoroJRestApi-baseUrl")}account";  }
        }
        public static string Feedback
        {
            get { return $"{CustomConfigurationProvider.GetKey("AltoroJRestApi-baseUrl")}feedback"; }
        }
        public static string Admin
        {
            get { return $"{CustomConfigurationProvider.GetKey("AltoroJRestApi-baseUrl")}admin"; }
        }
    }
}
