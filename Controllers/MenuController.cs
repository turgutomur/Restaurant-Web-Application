using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementApp.Models;

public class MenuController : Controller
{
    public static List<MenuItem> MenuItems = new List<MenuItem>
{
    // Main Courses
    new MenuItem
    {
        Id = 1,
        Name = "Pizza",
        Price = 12.99m,
        Category = "Main Course",
    },
    new MenuItem
    {
        Id = 2,
        Name = "Burger",
        Price = 10.99m,
        Category = "Main Course",
    },
    new MenuItem
    {
        Id = 3,
        Name = "Pasta Carbonara",
        Price = 14.99m,
        Category = "Main Course",
    },
    new MenuItem
    {
        Id = 4,
        Name = "Grilled Salmon",
        Price = 18.99m,
        Category = "Main Course",
    },

    // Appetizers
    new MenuItem
    {
        Id = 5,
        Name = "Garlic Bread",
        Price = 4.99m,
        Category = "Appetizers",
    },
    new MenuItem
    {
        Id = 6,
        Name = "Caesar Salad",
        Price = 6.99m,
        Category = "Appetizers",
    },

    // Desserts
    new MenuItem
    {
        Id = 7,
        Name = "Ice Cream",
        Price = 5.99m,
        Category = "Desserts",
    },
   
};


    public IActionResult Index()
    {
        return View(MenuItems);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(MenuItem menuItem)
    {
        menuItem.Id = MenuItems.Max(m => m.Id) + 1; // Auto-increment ID
        MenuItems.Add(menuItem);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var item = MenuItems.FirstOrDefault(m => m.Id == id);
        if (item == null)
            return NotFound();

        return View(item);
    }

    [HttpPost]
    public IActionResult Edit(MenuItem menuItem)
    {
        var item = MenuItems.FirstOrDefault(m => m.Id == menuItem.Id);
        if (item == null)
            return NotFound();

        item.Name = menuItem.Name;
        item.Price = menuItem.Price;
        item.Category = menuItem.Category;

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var item = MenuItems.FirstOrDefault(m => m.Id == id);
        if (item == null)
            return NotFound();

        MenuItems.Remove(item);

        return RedirectToAction("Index");
    }
}
