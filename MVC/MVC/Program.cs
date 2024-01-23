// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
using (var context = new MyContext())
{
    // Create and save a new Students
    Console.WriteLine("Adding new students");

    var student = new Student
    {
        FirstMidName = "Atyia",
        LastName = "Alam",
        FatherName="liaqat ali",
        RollNo="BCSF20A018",
        EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
    };

    context.Students.Add(student);

    var student1 = new Student
    {
        FirstMidName = "Ali",
        LastName = "Ahmed",
        FatherName = "liaqat ali",
        RollNo = "BCSF20A018",
        EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
    };

    context.Students.Add(student1);
    context.SaveChanges();

    // Display all Students from the database
    var students = (from s in context.Students
                    orderby s.FirstMidName
                    select s).ToList<Student>();

    Console.WriteLine("Retrieve all Students from the database:");

    foreach (var stdnt in students)
    {
        string name = stdnt.FirstMidName + " " + stdnt.LastName;
        Console.WriteLine("ID: {0}, Name: {1}", stdnt.ID, name);
    }

    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}
public enum Grade
{
    A, B, C, D, F
}
public class Enrollment
{
    public int EnrollmentID { get; set; }
    public int CourseID { get; set; }
    public int StudentID { get; set; }
    public Grade? Grade { get; set; }

    public virtual Course Course { get; set; }
    public virtual Student Student { get; set; }
}

public class Student
{
    public int ID { get; set; }
    public string LastName { get; set; }
    public string FirstMidName { get; set; }
    public string FatherName { get; set; }
    public string RollNo { get; set; }
    public DateTime EnrollmentDate { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; }
}

public class Course
{
    public int CourseID { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; }
}

public class MyContext : DbContext
{
    public virtual DbSet<Course> Courses { get; set; }
    public virtual DbSet<Enrollment> Enrollments { get; set; }
    public virtual DbSet<Student> Students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=mydatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

}


