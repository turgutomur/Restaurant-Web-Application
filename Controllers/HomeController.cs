using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementApp.Models;

namespace RestaurantManagementApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Check if the user is logged in
        var username = HttpContext.Session.GetString("Username");
        if (string.IsNullOrEmpty(username))
        {
            // If not logged in, redirect to the login page
            return RedirectToAction("Login", "Auth");
        }

        ViewData["Username"] = username; // Pass username to the view
        // If logged in, show the normal index page
        return View();
    }
    public IActionResult About()
    {
        return View();
    }

     public IActionResult Contact()
    {
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
