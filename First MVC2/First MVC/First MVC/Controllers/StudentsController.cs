
// Controllers/StudentsController.cs
using System.Linq;
using First_MVC.Data;
using First_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace First_MVC.Controllers
{
    public class StudentsController : Controller
        {
            private readonly AppDbContext _context;

            public StudentsController(AppDbContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
                var students = _context.Students.ToList();
                return View(students);
            }

            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Create(Student student)
            {
                if (ModelState.IsValid)
                {
                    _context.Students.Add(student);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(student);
            }
        }
    }
