using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace student_feedback_recommendation_system.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Status { get; set; }

        public string Subject { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfJoining { get; set; }

        
    }
}
