using System.Collections.Generic;

namespace AutomacaoAltoroJRestAPI.Models
{
    public class CreateAdminChangePassword_Request
    {
        public string username { get; set; }
        public string password1 { get; set; }
        public string password2 { get; set; }

    }
}
