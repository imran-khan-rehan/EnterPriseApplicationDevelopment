//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using student_feedback_recommendation_system.Data;

//namespace student_feedback_recommendation_system.Controllers
//{
//    public class TeacherController : Controller
//    {
//        private readonly AppDbContext _context;

//        public TeacherController(AppDbContext context)
//        {
//            _context = context;
//        }

//        public IActionResult Details(int id)
//        {
//            var teacher = _context.Teachers.Include(t => t.Reviews).FirstOrDefault(t => t.Id == id);

//            if (teacher == null)
//            {
//                return NotFound();
//            }

//            return View(teacher);
//        }
//    }
//}
