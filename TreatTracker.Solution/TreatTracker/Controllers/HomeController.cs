using Microsoft.AspNetCore.Mvc;

namespace TreatTracker.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}