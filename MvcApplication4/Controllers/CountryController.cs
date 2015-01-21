using MvcApplication4.Models;
using System.Linq;
using System.Web.Mvc;  
namespace Employee.Controllers 
{ 
    public class CountryController : Controller 
    { 
        public ActionResult Index() 
        { 
            return View(); 
        }

        public ActionResult details(LoginDetails loginInfo) 
        {
            LoginDetails da = new LoginDetails();
            string[] arrUser = new string[] { "ankit", "vipin", "ashumam", "anujsir", "hello", "kashif" }; 
            string[] arrPass = new string[] { "12345", "6789", "1234", "5678", "word", "123456" }; 
            da.UserName = loginInfo.UserName; 
            da.Password = loginInfo.Password;
            if (da.UserName == null || da.Password == null || da.UserName.Equals(da.Password))
            { 
                ViewBag.message = "Fill the information"; 
                return View("Index", da); 
            } 
          if (arrUser.Contains(da.UserName) && arrPass.Contains(da.Password)) 
          { 
              Session["user"] = da.UserName; 
                return RedirectToAction("success"); 
            } 
            else 
            { 
                ViewBag.message = "Invalid Username or Passowrd"; 
                return View("Index", da); 
            } 
        } 
        public ActionResult success() 
        { 
           ViewBag.name = Session["user"].ToString(); 
            return View("Success"); 
        } 
    } 
}