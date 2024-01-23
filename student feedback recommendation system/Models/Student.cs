using System.ComponentModel.DataAnnotations;

namespace student_feedback_recommendation_system.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
