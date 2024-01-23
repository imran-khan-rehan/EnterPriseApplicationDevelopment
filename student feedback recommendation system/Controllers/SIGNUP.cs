using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using student_feedback_recommendation_system.Data; 
using student_feedback_recommendation_system.Models;
using System;

namespace student_feedback_recommendation_system.Controllers
{
    public class SIGNUP : Controller
    {
        private readonly AppDbContext _context;

        public SIGNUP(AppDbContext context)
        {
            _context = context;
        }
        // GET: /signup
        public IActionResult Index()
        {
            return View();
        }

        // POST: /signup/createaccount
        [HttpPost]
        public IActionResult CreateAccount(string email, string password, string confirmPassword, bool terms)
        {
            // Perform validation and account creation logic here
            // For simplicity, let's just print the values to the console
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"ConfirmPassword: {confirmPassword}");
            Console.WriteLine($"Agreed to Terms: {terms}");
            Console.WriteLine(_context.Students.ToList().Count);
            // You would typically save the data to a database or perform other business logic here
           if(password==confirmPassword)
            {

            var user = new Student
            {
                Email = email, Password = password
            };
            _context.Students.Add(user);
            _context.SaveChanges();
            Console.WriteLine("data inserted");
            return RedirectToAction("Index", "SIGNIN");
            }
           else
            {
                TempData["ErrorMessage"] = "Password and Confirm Password do not match.";
                return RedirectToAction("Index");
            }
            // Redirect to a success page or return a view
        }
    }
}
