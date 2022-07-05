using Microsoft.AspNetCore.Identity;

namespace MicrosoftTeams.Models
{
    public class User : IdentityUser
    {
        public int BirthYear { get; set; }
    }
}
