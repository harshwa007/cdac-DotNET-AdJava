using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentDemo.Models;
using BLL;
using BOL;
using System.Text;
namespace StudentDemo.Controllers;

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
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(int c1,string c2, string c3, int c4)
    {
        bool status = StudentManager.Add(c1,c2,c3,c4);
        if(status)
        {
            return Redirect("Index");
        }
        return View();
    }
   [HttpGet]
    public IActionResult Delete()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Delete(int d1)
    {
        bool status = StudentManager.Delete(d1);
        if(status)
        {
            return Redirect("Index");
        }
        return View();
    }
   [HttpGet]
    public IActionResult Update()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Update(int u1,string u2, string u3, int u4)
    {
        bool status = StudentManager.Update(u1,u2,u3,u4);
        if(status)
        {
            return Redirect("Index");
        }
        return View();
    }
   [HttpGet]
    public IActionResult Find(int i1)
    {
        List<Student> list = StudentManager.Find(i1);
        ViewData["b"] = list;
        return View();
    }
   [HttpGet]
    public IActionResult GetAll()
    {
        List<Student> list = StudentManager.All();
        ViewData["b"] = list;
        return View();
    }
}
