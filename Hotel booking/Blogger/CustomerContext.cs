using System.Data.Entity;

namespace Hotel_booking.Models
{
    public class CustomerContext:DbContext
    {
      public DbSet<New_User> clients { get; set; }
    
        
    }
}