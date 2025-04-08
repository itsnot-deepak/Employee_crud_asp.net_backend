using System.ComponentModel.DataAnnotations;

namespace Employee_Main.Models.Entities
{
    public class departments
    {
        [Key]
        public Guid departmentId { get; set; }
        public required string DepartmentName  { get; set; }

        public ICollection<employee> Employees { get; set; }
    }
}
