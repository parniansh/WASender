using Microsoft.AspNetCore.Identity;

namespace Model.Model
{
    public class ApplicationRole : IdentityRole<int>
    {
        public RoleType Type { get; set; }
    }
}
