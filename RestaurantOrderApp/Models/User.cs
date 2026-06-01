using Microsoft.AspNetCore.Identity;

namespace RestaurantOrderApp.Models
{
    public class User : IdentityUser
    {
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}