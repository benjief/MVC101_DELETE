using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mvc101.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        public ActionResult Index()
        {
            return View(Process.GetProcesses());
        }

        public ActionResult Display(int id)
        {
            return View(Process.GetProcessById(id));
        }

        // GET: Process/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}