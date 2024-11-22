using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      int hour = DateTime.Now.Hour;
      ViewBag.Greeting = hour < 12 ? "Günaydın" : "İyi Günler";
      int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
      var meetingInfo = new MeetingInfo();
      {
        meetingInfo.MeetingId = 1;
        meetingInfo.NumberOfPeople = UserCount;
        meetingInfo.MeetingDescription = "Toplantı";
        meetingInfo.MeetingDate = DateTime.Now;
        meetingInfo.MeetingLocation = "İstanbul";
      }
      return View(meetingInfo);
    }


  }
}