using Microsoft.AspNetCore.Identity;

namespace Article.Models;

public class ApplicationUser : IdentityUser<Guid>
{
    public string Name { get; set; } = string.Empty; // You can add additional properties here if needed
                                                     // For example:
                                                     // public string FullName { get; set; }
                                                     // public DateTime DateOfBirth { get; set; }
}
