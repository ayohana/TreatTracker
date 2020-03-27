using Microsoft.AspNetCore.Mvc;

namespace TreatTracker.Controllers
{
  public class HomeController : Controller
  {

    public ActionResult Index()
    {
      return View();
    }

  }
}