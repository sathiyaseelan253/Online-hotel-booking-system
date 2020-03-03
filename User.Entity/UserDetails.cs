using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Myproject_Hotel_booking_system.Models
{

    public class UserDetails
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }
      
        public string  firstName { get; set; }
        
        public string  lastName { get; set; }
       
        public string Email { get; set; }
       
        public string Password { get; set; }
        
      
        public string confirmPassword { get; set; }
      
        public string userName { get; set; }
    }
}