using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_hotel_booking_system.Models
{
    public class Accounts
    {
        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        public string LastName { get; set; }

        [Display(Name = "Email ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email ID required")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        public int Age{get;set;}

            [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Minimum 6 characters required")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password and password do not match")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "ContactNo")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Contact number is required")]



        public long ContactNo { get; set; }
        [Display(Name ="Address")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Address is required")]
        public string Address { get; set; }
      

       static List<Accounts> accounts = new List<Accounts>()
        {
            new Accounts{ FirstName="Sathiyaseean",LastName="R", EmailID="sathyaseelan253@gmail.com", ContactNo=8072117799, Address="12,Raja nagar,Nellur,Karur-936004", Password="8072"},
             new Accounts{ FirstName="Arun",LastName="Vijay", EmailID="arun@gmail.com", Age=22, ContactNo=9566580353, Address="1/12,Sellur mah,Karunji,Madurai-936004",Password="12345"}

        };
        static string result = "no";
        public string CheckValidUser(string email,string password)
        {
           
            foreach(Accounts info in accounts)
            {
                if (info.EmailID == email && info.Password == password)
                    return result="yes";                             
            }
            return result;

        }
        public void AddToList(Accounts information)
        {
            accounts.Add(information);
        }
    }
}