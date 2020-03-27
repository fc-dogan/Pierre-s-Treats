using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using PierresTreats.Models;

namespace PierresTreats.Controllers
{
  public class TreatsController : Controller
  {
    private readonly PierresTreatsContext _db;

    public TreatsController(PierresTreatsContext db)
    {
      _db =db;
    }

    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.Include(treats => treats.Flavors).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat)
    {
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisTreat = _db.Treats
          .Include(treat => treat.Flavors)
          .ThenInclude(join => join.Flavor)
          .FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    public ActionResult AddFlavor(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(Treats => Treats.TreatId == id);
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult AddFlavor(Treat Treat, int FlavorId)
    {
      if (FlavorId != 0)
      {
        _db.TreatFlavor.Add(new TreatFlavor() { FlavorId = FlavorId, TreatId = Treat.TreatId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    
    //  public ActionResult Delete(int id)
    // {
    //   var thisTreat = _db.Treats.FirstOrDefault(Treats => Treats.TreatId == id);
    //   return View(thisTreat);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisTreat = _db.Treats.FirstOrDefault(Treats => Treats.TreatId == id);
    //   _db.Treats.Remove(thisTreat);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index", "Flavors");
    // }

    // public ActionResult Edit(int id)
    // {
    //   var thisTreat = _db.Treats.FirstOrDefault(Treats => Treats.TreatId == id);
    //   ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
    //   return View(thisTreat);
    // }

    // [HttpPost]
    // public ActionResult Edit(Treat treat)
    // {
    //   _db.Entry(treat).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

  }
  
}