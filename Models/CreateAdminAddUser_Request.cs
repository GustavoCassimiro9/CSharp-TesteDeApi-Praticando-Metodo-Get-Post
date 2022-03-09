using System.Collections.Generic;

namespace AutomacaoAltoroJRestAPI.Models
{
    public class CreateAdminAddUser_Request
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string password1 { get; set; }
        public string password2 { get; set; }

    }
}
