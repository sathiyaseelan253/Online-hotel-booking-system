using System.ComponentModel.DataAnnotations;

namespace Hotel_booking.Models
{
    public class LoggedInCustomer
    {
        [Required(ErrorMessage = "Please enter user-name")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }
    }
}