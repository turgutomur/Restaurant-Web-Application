using Microsoft.AspNetCore.Mvc;
using RestaurantManagementApp.Models;
using System.Collections.Generic;
using System.Linq;
public class AuthController : Controller
{
    public IActionResult Index()
{
    // Check if the user is logged in
    var username = HttpContext.Session.GetString("Username");
    if (string.IsNullOrEmpty(username))
    {
        // If not logged in, redirect to the login page
        return RedirectToAction("Login", "Auth");
    }

    // If logged in, show the normal index page
    return View();
}
    // Show the login page
    public IActionResult Login()
    {
        return View();
    }

    // Handle login logic (this is just a simple example, you should implement proper authentication)
    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        // Example: Check credentials (this should be done using a proper authentication service)
        if (username == "admin" && password == "password") 
        {
            // Store user info in session or cookies to indicate they are logged in
            HttpContext.Session.SetString("Username", username);
            return RedirectToAction("Index", "Home"); // Redirect to the home/index page
        }
        else
        {
            // Return to login page with an error message
            ViewBag.Error = "Invalid credentials.";
            return View();
        }
    }

    // Logout logic
    public IActionResult Logout()
    {
        // Clear session or cookies
        HttpContext.Session.Remove("Username");
        return RedirectToAction("Login", "Auth");
    }
}
