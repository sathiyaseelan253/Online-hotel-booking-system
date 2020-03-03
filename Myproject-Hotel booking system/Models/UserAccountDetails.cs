using System.Data.Entity;

namespace Myproject_Hotel_booking_system.Models
{
    public class UserAccountDetails
    {
        public DbSet<UserDetails> userDetails { get; set; }
    }
}