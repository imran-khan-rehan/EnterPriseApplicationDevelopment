
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using student_feedback_recommendation_system.Data;
using student_feedback_recommendation_system.Models;
using System;
using Microsoft.EntityFrameworkCore;

namespace student_feedback_recommendation_system.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
     
        public IActionResult dashboard()
        {
            var studentId = HttpContext.Session.GetInt32("StudentId");
            var studentName = HttpContext.Session.GetString("StudentName");

            if (studentId.HasValue && !string.IsNullOrEmpty(studentName))
            {
               
                var teachers = _context.Teachers.ToList();

                Console.WriteLine(teachers);
                ViewBag.name =studentName.Split('@');

                return View(teachers);
            }
            else
            {
                // Redirect to sign-in or handle as appropriate
                return RedirectToAction("Index","SIGNIN");
            }
          
        }
        public IActionResult Details(int id)
        {
            var studentId = HttpContext.Session.GetInt32("StudentId");
            var studentName = HttpContext.Session.GetString("StudentName");

            // Check if the student is signed in
            if (studentId.HasValue && !string.IsNullOrEmpty(studentName))
            {
                // Student is signed in, proceed with your logic
                // ...
            var reviews = _context.Reviews
                        .Where(r => r.TeacherId == id)
                        .ToList();
            ViewBag.TeacherId = id;


            return View(reviews);
            }
            else
            {
                // Redirect to sign-in or handle as appropriate
                return RedirectToAction("Index", "SIGNIN");
            }
        }
        public IActionResult GetReview(int id)
        {
            var studentId = HttpContext.Session.GetInt32("StudentId");
            var studentName = HttpContext.Session.GetString("StudentName");

            // Check if the student is signed in
            if (studentId.HasValue && !string.IsNullOrEmpty(studentName))
            {
                // Student is signed in, proceed with your logic
                // ...
            ViewBag.TeacherId = id;

            return View();
            }
            else
            {
                // Redirect to sign-in or handle as appropriate
                return RedirectToAction("Index", "SIGNIN");
            }
        }

        [HttpPost]
        public IActionResult CreateReview(int teacherId, string comment, int rating)
        {
            // Perform validation and account creation logic here
            // For simplicity, let's just print the values to the console
            Console.WriteLine($"Email: {comment}");
            Console.WriteLine($"Password: {teacherId}");
           
            Console.WriteLine(_context.Students.ToList().Count);
            // You would typically save the data to a database or perform other business logic here
           
            if (teacherId!=null)
            {

                var user = new Review
                {
                    Comment = comment,
                    Rating = rating,
                    DatePosted= DateTime.Now,
                    TeacherId=teacherId

                };
                _context.Reviews.Add(user);
                _context.SaveChanges();
                Console.WriteLine("data inserted");
                return RedirectToAction("Thankyou", "Home");
            }
            
            else
            {
                TempData["ErrorMessage"] = "Password and Confirm Password do not match.";
                return RedirectToAction("Index");
            }
            // Redirect to a success page or return a view
        }
        public IActionResult Thankyou()
        {
            var studentId = HttpContext.Session.GetInt32("StudentId");
            var studentName = HttpContext.Session.GetString("StudentName");

            // Check if the student is signed in
            if (studentId.HasValue && !string.IsNullOrEmpty(studentName))
            {
                // Student is signed in, proceed with your logic
                // ...
            return View();
            }
            else
            {
                // Redirect to sign-in or handle as appropriate
                return RedirectToAction("Index", "SIGNIN");
            }
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}