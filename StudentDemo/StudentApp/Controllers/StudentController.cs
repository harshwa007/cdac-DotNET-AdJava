using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;
using BLL.StudentManager;
using BOL;
namespace StudentApp.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
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
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(int c1,string c2,string c3, int c4)
    {
        bool status = StudentManager.Add(c1,c2,c3,c4);
        if(status)
        {
            return Redirect("/Student/Index");
        }
        return View();
    }

    // [HttpGet]
    // public IActionResult Allstudent()
    // {
    //     return View();
    // }
    // [HttpPost]
    public IActionResult Allstudent()
    {
        List<Student> s3 = StudentManager.GetAll(); 
        
        ViewData["S3"] = s3;
        return View();
    }
}
