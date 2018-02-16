using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View("Index");
        }

        [HttpPost("/")]
        public ActionResult Count()
        {
          RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["word"], Request.Form["text"]);
          newRepeatCounter.SetSplitText();
          newRepeatCounter.DoCount();
          return View("Count", newRepeatCounter);
        }
    }
}
