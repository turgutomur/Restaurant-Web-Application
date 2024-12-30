using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantManagementApp.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string?   Category { get; set; }
        public int RestaurantID { get; set; }
        public static List<Menu> Menus = new List<Menu>();
}
    }
    
