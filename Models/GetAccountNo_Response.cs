using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace AutomacaoAltoroJRestAPI.Models
{
    public class GetAccountNo_Response
    {
        [JsonPropertyName("accountId")]
        public string accountId { get; set; }

        [JsonPropertyName("balance")]
        public string balance { get; set; }

        [JsonPropertyName("credits")]
        public List<Credits> credits { get; set; }
    }
    public class Credits
    {
        [JsonPropertyName("date")]
        public string date { get; set; }

        [JsonPropertyName("amount")]
        public string amount { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("account")]
        public string account { get; set; }


    }
}
