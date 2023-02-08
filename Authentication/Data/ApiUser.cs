using Microsoft.AspNetCore.Identity;

namespace Authentication.Data
{
    public class ApiUser : IdentityUser
    {

        public String FullName { get; set; }

    }
}
