using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Note_CRUD.Models;

namespace Note_CRUD.Controllers {
  public class NoteController : Controller {
    public IActionResult Index () {
      NoteContext context = HttpContext.RequestServices.GetService (typeof (Note_CRUD.Models.NoteContext)) as NoteContext;

      return View (context.GetAll ());
    }

    public IActionResult Get (int id) {
      NoteContext context = HttpContext.RequestServices.GetService (typeof (Note_CRUD.Models.NoteContext)) as NoteContext;

      return View (context.Get (id));
    }

    public IActionResult Edit (int id, [Bind ("titulo", "autor", "nota")] Note n) {
      NoteContext context = HttpContext.RequestServices.GetService (typeof (Note_CRUD.Models.NoteContext)) as NoteContext;

      return View (context.Edit (id, n));
    }

    public IActionResult Del (int id) {
      NoteContext context = HttpContext.RequestServices.GetService (typeof (Note_CRUD.Models.NoteContext)) as NoteContext;
      context.Del (id);

      return RedirectToAction ("");
    }

    public IActionResult Add ([Bind ("titulo", "autor", "nota")] Note n) {
      NoteContext context = HttpContext.RequestServices.GetService (typeof (Note_CRUD.Models.NoteContext)) as NoteContext;

      if (context.Add (n)) {
        return RedirectToAction ("");
      }

      return View ();
    }
  }
}