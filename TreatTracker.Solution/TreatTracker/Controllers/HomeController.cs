using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Collections.Generic;
using System.Linq;
using System;
using TreatTracker.Models;

namespace TreatTracker.Controllers
{
  public class HomeController : Controller
  {
    private readonly TreatTrackerContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(UserManager<ApplicationUser> userManager, TreatTrackerContext db)
    {
       _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
      Dictionary<int, string> userCompleteList = new Dictionary<int, string> ();
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userFlavors = _db.Flavors.Where(entry => entry.User.Id == currentUser.Id).OrderBy(flavor => flavor.Type).ToList();
      var userTreats = _db.Treats.Where(entry => entry.User.Id == currentUser.Id).OrderBy(treat => treat.Name).ToList();
      int number = 0;
      userCompleteList.Add(number++, "ALL YOUR FLAVORS");
      foreach (var flavor in userFlavors)
      {
        userCompleteList.Add(number, flavor.Type);
        number++;
      }
      userCompleteList.Add(number++, "ALL YOUR TREATS");
      foreach(var treat in userTreats)
      {
        userCompleteList.Add(number, treat.Name);
        number++;
      }
      return View(userCompleteList);
    }

  }
}