using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SampleSecuredWeb.Models;

namespace SampleSecuredWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Username = "Javier Baswara";
        string[] fruits = new string[]{"Apple", "Banana", "Orange"};
        ViewBag.fruits = fruits;
        return View();
        return View();
    }
public IActionResult about() {
        ViewData["Title"]= "About Page";
        return View();
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
