using System.Text.Json.Serialization;

namespace AutomacaoAltoroJRestAPI.Models
{
    public class GetLogout_Response
    {
        [JsonPropertyName("LoggedOut")]
        public string LoggedOut { get; set; }
    }
}
