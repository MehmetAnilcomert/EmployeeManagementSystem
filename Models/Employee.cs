using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StajProjesi.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }

        public int JobId { get; set; }

        public int? ManagerId { get; set; }

        public ICollection<Employee> Subordinates { get; set; }

        public int DepartmentId { get; set; }

        public ICollection<Dependent> Dependents { get; set; }
    }
}
