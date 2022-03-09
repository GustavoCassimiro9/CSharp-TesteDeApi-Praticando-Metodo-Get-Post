using System.Collections.Generic;

namespace AutomacaoAltoroJRestAPI.Models
{
    public class CreateTransfer_Request
    {
        public string toAccount { get; set; }
        public string fromAccount { get; set; }
        public string transferAmount { get; set; }

    }
}
