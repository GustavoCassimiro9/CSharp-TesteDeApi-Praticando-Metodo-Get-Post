using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AutomacaoAltoroJRestAPI.Models
{
    public class GetAccount_Response
    {
        [JsonPropertyName("Accounts")]
        public List<Accounts> accounts { get; set; }
    }
    public class Accounts
    {
        [JsonPropertyName("Name")]
        public string name { get; set; }

        [JsonPropertyName("id")]
        public string id { get; set; }

    }

}
