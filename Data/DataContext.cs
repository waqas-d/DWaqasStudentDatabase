using DWaqasStudentDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace DWaqasStudentDatabase.Data;

public class DataContext : DbContext
{
    // This sets up database functionality on the class
    // DbContextOptions<DataContext> is an EF Core class that allows us to access database configuration settings like the connection string
    public DataContext(DbContextOptions<DataContext> options) : base(options) // The base keyword is allowing us to access stuff from the base or parent class
    {
            
    }

    public DbSet<Student> CRUD { get; set; }
}

