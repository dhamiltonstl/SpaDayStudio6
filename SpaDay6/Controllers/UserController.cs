
using Microsoft.AspNetCore.Mvc;


namespace SpaDay6.Controllers;


public class UserController : Controller
{
   [HttpGet("/user/add")]
   public IActionResult Add()
   {
      return View();
   }

[HttpPost("/user")]
   public IActionResult SubmitAddUserForm(User newUser, string verify) 
   {
   // add form submission handling code here
      if (verify == newUser.Password)
      {
         ViewBag.userName = newUser.Username;
         return View("Index");
      }
      ViewBag.Error = "Passwords don't match!";
      return View("Add");
   }
}
