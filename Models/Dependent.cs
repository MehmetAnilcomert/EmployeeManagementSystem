using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StajProjesi.Models
{
    public class Dependent
    {
        [Key]
        public int DependentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Relationship { get; set; }

        public int EmployeeId { get; set; }
    }
}
