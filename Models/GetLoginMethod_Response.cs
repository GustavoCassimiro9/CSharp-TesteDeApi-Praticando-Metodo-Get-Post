using System.Text.Json.Serialization;
namespace AutomacaoAltoroJRestAPI.Models
{
    public class GetLoginMethod_Response
    {
        [JsonPropertyName("username")]
        public string username { get; set; }

        [JsonPropertyName("password")]
        public string password { get; set; }
        
   


    }

}
