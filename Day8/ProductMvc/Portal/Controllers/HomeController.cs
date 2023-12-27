using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using System.Collections.Generic;
namespace Portal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Person p1 = new Person { Id = 1, FirstName = "Saurbh", LastName = "Zadtude" };
        Person p2 = new Person { Id = 2, FirstName = "Saurbh", LastName = "Phultude" };
        List<Person> Family = new List<Person>();
        Family.Add(p1);
        Family.Add(p2);
        this.ViewData["bfamily"] = Family;
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
}
