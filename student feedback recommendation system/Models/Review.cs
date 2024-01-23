using System;
using System.ComponentModel.DataAnnotations;

namespace student_feedback_recommendation_system.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Comment { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        [DataType(DataType.Date)]
        public DateTime DatePosted { get; set; }

        public int TeacherId { get; set; }

    }
}
