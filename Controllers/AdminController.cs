// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using System.Linq;

// public class AdminController : Controller
// {
//     private readonly ApplicationDbContext _context;

//     public AdminController(ApplicationDbContext context)
//     {
//         _context = context;
//     }

//     // GET: Admin
//     public IActionResult Index()
//     {
//         var admins = _context.Admins.ToList();
//         return View(admins);
//     }

//     // GET: Admin/Create
//     public IActionResult Create()
//     {
//         return View();
//     }

//     // POST: Admin/Create
//     [HttpPost]
//     [ValidateAntiForgeryToken]
//     public IActionResult Create(Admin admin)
//     {
//         if (ModelState.IsValid)
//         {
//             _context.Admins.Add(admin);
//             _context.SaveChanges();
//             return RedirectToAction(nameof(Index));
//         }
//         return View(admin);
//     }

//     // GET: Admin/Edit/{id}
//     public IActionResult Edit(int id)
//     {
//         var admin = _context.Admins.Find(id);
//         if (admin == null)
//         {
//             return NotFound();
//         }
//         return View(admin);
//     }

//     // POST: Admin/Edit/{id}
//     [HttpPost]
//     [ValidateAntiForgeryToken]
//     public IActionResult Edit(int id, Admin admin)
//     {
//         if (id != admin.Id)
//         {
//             return BadRequest();
//         }

//         if (ModelState.IsValid)
//         {
//             _context.Admins.Update(admin);
//             _context.SaveChanges();
//             return RedirectToAction(nameof(Index));
//         }
//         return View(admin);
//     }

//     // GET: Admin/Delete/{id}
//     public IActionResult Delete(int id)
//     {
//         var admin = _context.Admins.Find(id);
//         if (admin == null)
//         {
//             return NotFound();
//         }
//         return View(admin);
//     }

//     // POST: Admin/Delete/{id}
//     [HttpPost, ActionName("Delete")]
//     [ValidateAntiForgeryToken]
//     public IActionResult DeleteConfirmed(int id)
//     {
//         var admin = _context.Admins.Find(id);
//         if (admin != null)
//         {
//             _context.Admins.Remove(admin);
//             _context.SaveChanges();
//         }
//         return RedirectToAction(nameof(Index));
//     }
// }
