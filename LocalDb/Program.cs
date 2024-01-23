using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
Console.WriteLine("hello world");

using (var context = new MyContext())
{
    // Create and save a new User
    Console.WriteLine("Adding a new user");

    var user = new students
    {
        Name = "imran"
    };

    context.Student.Add(user);
    context.SaveChanges();
}

public class users
{
    public int Id { get; set; }
    public string Name { get; set; }

}
public class students
{
    [Key]
    public int StudentId { get; set; }
    public string Name { get; set; }

}

public class MyContext : DbContext
{
    public virtual DbSet<users> User1 { get; set; }
    public virtual DbSet<students> Student { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=mydatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
}
