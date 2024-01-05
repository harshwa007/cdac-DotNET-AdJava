using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TimeSheetSoln.Models;
using BLL;
using BOL;
namespace TimeSheetSoln.Controllers;

public class TimeController : Controller
{
    private readonly ILogger<TimeController> _logger;

    public TimeController(ILogger<TimeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Insert(string i1,string i2,int i3,string i4)
    {
        bool status=TimeSheetManager.AddDetails(i1,i2,i3,i4);
        if(status)
        {
            return Redirect("Index");
        }
        return View();
    }
    public IActionResult Update()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Update(string u1,string u2,int u3,string u4)
    {
        bool status=TimeSheetManager.UpdateDetails(u1,u2,u3,u4);
        if(status)
        {
            return Redirect("Index");
        }
        return View();
    }
    [HttpGet]
    public IActionResult Show()
    {
        List<TimeSheet> list = TimeSheetManager.GetDetails();
        ViewData["b"] = list;
        return View();
    }
}
