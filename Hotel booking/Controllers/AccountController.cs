using Hotel_booking.Models;
using System.Web.Mvc;

namespace Hotel_booking.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Success()
        {
            return View();
        }
        // GET: Account
        [ActionName("Signup")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Signup")]
        public ActionResult Signup(New_User user)
        {
            using (CustomerContext context = new CustomerContext())
            {
                context.clients.Add(user);
                context.SaveChanges();
            }
            return View("Success");
        }
    }
}