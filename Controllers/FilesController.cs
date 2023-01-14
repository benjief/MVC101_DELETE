using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mvc101.Controllers
{
    public class FilesController : Controller
    {
        // GET: Process
        public IActionResult Index()
        {
            // return View(Directory.GetFiles(Path.GetFullPath("C:\\COMP_4870\\Mvc101\\TextFiles")));
            return View(Directory.GetFiles("./TextFiles"));
        }

        public ActionResult Content(string id) // routing rules mean that this HAS to be called id?
        {
            // Console.WriteLine("id is: " + id);
            string lines = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "\\TextFiles\\" + id);
            ViewData["lines"] = lines;
            return View();
        }

        // // GET: Files/id/5
        // public ActionResult Details(int id)
        // {
        //     return View();
        // }
    }
}