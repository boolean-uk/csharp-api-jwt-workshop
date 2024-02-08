using workshop.webapi.Enums;
using Microsoft.AspNetCore.Identity;

namespace workshop.webapi.Models;

public class ApplicationUser : IdentityUser
{
    public Role Role { get; set; }
}