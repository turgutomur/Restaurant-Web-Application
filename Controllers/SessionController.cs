using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementApp.Models;

public class SessionController : Controller
{
    private static List<Session> Sessions = new();
    private static List<MenuItem> MenuItems = MenuController.MenuItems; // Reuse menu items

    public IActionResult Index()
    {
        return View(Sessions);
    }

    public IActionResult Create()
    {
        ViewBag.MenuItems = MenuItems; // Pass menu items to view
        return View(new Session());
    }

    [HttpPost]
    public IActionResult Create(Session session, int[] selectedItemIds)
    {
        session.Id = Sessions.Count + 1;
        session.Items = MenuItems.Where(m => selectedItemIds.Contains(m.Id)).ToList(); // Corrected to map MenuItem objects
        session.SelectedItemIds = selectedItemIds.ToList();
        Sessions.Add(session);

        return RedirectToAction("Index");
    }


    
}
