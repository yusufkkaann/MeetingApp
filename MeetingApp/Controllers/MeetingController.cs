using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
  public class MeetingController : Controller
  {

    [HttpGet]
    public IActionResult List()
    {
      return View(Repository.Users);
    }
    [HttpGet]
    public IActionResult Apply()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Apply(UserInfo user)
    {
      if (ModelState.IsValid)
      {
        Repository.AddUser(user);
        ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
        return View("Thanks", user);
      }
      else
      {
        return View(user);
      }

    }
    public IActionResult Details(int id)
    {
      return View(Repository.GetUserById(id));
    }



  }
}