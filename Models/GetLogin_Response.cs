using System.Text.Json.Serialization;
namespace AutomacaoAltoroJRestAPI.Models
{
    public class GetLogin_Response
    {
        [JsonPropertyName("loggedin")]
        public string loggedin { get; set; }
    }
}
