using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Template.Models;

namespace Template.Controllers
{
    public class HomeController: Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}