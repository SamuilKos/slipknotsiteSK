using Microsoft.AspNetCore.Identity;
using Slipknotssite.Data;

namespace Slipknotssite.Controllers
{
    public class User:IdentityUser
    {
        //public string Name { get; set; }
        //public string Password { get; set; }
        public string FullName { get; set; }
        public RoleType Role { get; set; } 
    }
}
