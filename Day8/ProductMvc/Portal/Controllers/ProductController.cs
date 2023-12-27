using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using System.Collections.Generic;
using System.Data.Common;
using BOL;
using BLL;
namespace Portal.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Product()
    {
        CatalogManager obj = new CatalogManager();
        List<Product> l=obj.GetAll();
          ViewData["allProducts"]=l;
        return View();

    }

    
}
