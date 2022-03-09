using System.Collections.Generic;

namespace AutomacaoAltoroJRestAPI.Models
{
    public class CreateFeedbackSubmit_Request
    {
        public string name { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }

    }
}
