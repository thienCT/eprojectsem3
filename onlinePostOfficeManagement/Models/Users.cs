using Microsoft.AspNetCore.Identity;

namespace onlinePostOfficeManagement.Models
{

    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }

}
