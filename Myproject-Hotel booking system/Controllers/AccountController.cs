using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Myproject_Hotel_booking_system.Models;
using User.Entity;
using static Myproject_Hotel_booking_system.Models.OurDbContent;

namespace Myproject_Hotel_booking_system.Controllers
{
    public class AccountController : Controller
    {

        //[HttpGet]
        //[ActionName("Into_Login")]
        //public ActionResult Index()
        //{

        //    using (userDetailsContext context = new userDetailsContext())
        //    {

        //        List<UserDetails> userList = context.userDetails.ToList();

        //    }
        //    return View();

        //}
        [HttpGet]
        [ActionName("SignUp")]
        public ActionResult Sign_Up()
        {


            return View();

        }
        [HttpPost]
        [ActionName("SignUp")]
        public ActionResult SignUp_Post(SignUp_Account details)
        {

            OurDbContent content = new OurDbContent();
            content.AddUser(details);
            return View();

        }
        //[HttpPost]
        //[ActionName("Into_Login")]
        //public ActionResult Login_post()
        //{
        //    using (userDetailsContext context = new userDetailsContext())
        //    {

        //        List<UserDetails> userList = context.userDetails.ToList();

        //    }
        //    return View();
        //}
    }
}
        //GET: Account




    //    public ActionResult Index()
    //    {
    //        return View();

    //    }
    //    [HttpGet]
    //    [ActionName("Register")]
    //    public ActionResult Register_Get()

    //    {
    //        return View();
    //    }
    //    [HttpPost]
    //    [ActionName("Register")]
    //    public ActionResult Register_Post()
    //    {


    //        SignUp_Account account = new SignUp_Account();
    //        TryUpdateModel(account);
    //        OurDbContent userLayer = new OurDbContent();
    //        if (ModelState.IsValid)
    //        {
    //            userLayer.AddUser(account);
    //            return RedirectToAction("Login");
    //        }
    //        return View();
    //    }
    //    [HttpGet]
    //    [ActionName("Login")]
    //    public ActionResult Login_Get()
    //    {
    //        return View();
    //    }
    //    [HttpPost]
    //    [ActionName("Login")]

    //    public ActionResult Login_Post()
    //    {
    //        Login_Account account = new Login_Account();
    //        if (ModelState.IsValid)
    //        {
    //            bool status = OurDbContent.Autheticate_User(account);
    //            if (status)
    //            {
    //                return RedirectToAction("LoggedIn");
    //            }


    //            return View();
    //        }
    //        return View();
    //    }

    //    public ActionResult LoggedIn()
    //    {
    //        if (Session["UserId"] != null)
    //            return View();
    //        else
    //            return RedirectToAction("Index");

    //    }

    //}
