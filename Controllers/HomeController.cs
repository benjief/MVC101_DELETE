using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mvc101.Models;

namespace Mvc101.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        ViewData["days"] = days;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Bogus()
    {
        string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        ViewData["author"] = "Benjie Friedman"; // a view data dictionary entry with key author and value your name
        ViewBag.Date = DateTime.Now; // an alternative to ViewData - equivalent to the above line
        return View(days); // need to actually make this view in Views folder - note that you can pass the array to the view as an argument
    }
}
