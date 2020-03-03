using Online_hotel_booking_system.Models;
using System.Web.Mvc;

namespace Online_hotel_booking_system.Controllers
{
    public class IndexController : Controller
    {
        Accounts accounts = new Accounts();
        // GET: Index
        [HttpGet]
        [ActionName("Log_In")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Login_post")]
        public ActionResult Login(string email,string password)
        {
            var status=accounts.CheckValidUser(email,password);
            if (status=="yes")
            {
                return RedirectToAction("GoHome");
            }
            else
            {
                ViewBag.Message = "UserName or password is wrong";
                return View();
            }
            
        }
        [HttpGet]
        [ActionName("Sign_up")]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Post_Details")]
        public ActionResult SignUp(Accounts userDetails)
        {
            accounts.AddToList(userDetails);
            return View("");
        }
        public ActionResult GoHome()
        {
            return View("Log_In");
        }
    }
    
}