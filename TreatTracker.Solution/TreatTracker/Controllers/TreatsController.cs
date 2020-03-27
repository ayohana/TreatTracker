using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TreatTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace TreatTracker.Controllers
{
  public class TreatsController : Controller
  {
    private readonly TreatTrackerContext _db;

    public TreatsController(TreatTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }

    public ActionResult Details(int id)
    {
      var thisTreat = _db.Treats
          .Include(treat => treat.Flavors)
          .ThenInclude(join => join.Flavor)
          .FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    public ActionResult Create()
    {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Type");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat, int FlavorId)
    {
      _db.Treats.Add(treat);
      if (FlavorId != 0)
      {
        _db.TreatFlavor.Add(new TreatFlavor() { FlavorId = FlavorId, TreatId = treat.TreatId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // public ActionResult Edit(int id)
    // {
    //   var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   return View(thisCategory);
    // }

    // [HttpPost]
    // public ActionResult Edit(Category category)
    // {
    //   _db.Entry(category).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   return View(thisCategory);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   _db.Categories.Remove(thisCategory);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}
