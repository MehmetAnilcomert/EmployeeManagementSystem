using Microsoft.EntityFrameworkCore;
using StajProjesi.Models;
using System.Diagnostics.Metrics;

public class EmployeeDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public EmployeeDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Job> Jobs { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Dependent> Dependents { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}