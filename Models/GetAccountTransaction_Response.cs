using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AutomacaoAltoroJRestAPI.Models
{
    public class GetAccountTransaction_Response
    {
        [JsonPropertyName("last_10_transactions")]
        public List<last_10_transactionsList> last_10_transactions { get; set; }
        
    }
    public class last_10_transactionsList
    {
        [JsonPropertyName("date")]
        public string date { get; set; }

        [JsonPropertyName("transaction_type")]
        public string transactionType { get; set; }

        [JsonPropertyName("ammount")]
        public string ammount { get; set; }
    }
}
