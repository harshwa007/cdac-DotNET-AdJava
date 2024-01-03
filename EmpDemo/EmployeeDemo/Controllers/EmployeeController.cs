using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmployeeDemo.Models;
using BLL.EmployeeManager;
using BOL.Employee;
namespace EmployeeDemo.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult AddEmp()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddEmp(int c1,string c2,string c3,string c4)
    {
        bool status = EmployeeManager.Add(c1,c2,c3,c4);
        if(status)
        {
            return Redirect("Index");
        }
        return View();
    }
    [HttpGet]
    public IActionResult UpdateEmp()
    {
        return View();
    }
    [HttpPost]
    public IActionResult UpdateEmp(int u1,string u2,string u3,string u4)
    {
        bool status = EmployeeManager.Update(u1,u2,u3,u4);
        if(status)
        {
            return Redirect("Index");
        }
        return View();
    }
    [HttpGet]
    public IActionResult DeleteEmp()
    {
        return View();
    }
    [HttpPost]
    public IActionResult DeleteEmp(int d1)
    {
        bool status = EmployeeManager.Delete(d1);
        if(status)
        {
            return Redirect("Index");
        }
        return View();
    }
    public IActionResult FindEmp(int f1)
    {
        List<Employee> list= EmployeeManager.FindEmp(f1);
        ViewData["b"] = list;
        return View();
    }
    public IActionResult GetAll()
    {
        List<Employee> list= EmployeeManager.GetList();
        ViewData["b1"] = list;
        return View();
    }
}
