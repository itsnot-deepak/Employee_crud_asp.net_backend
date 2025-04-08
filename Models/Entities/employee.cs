using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee_Main.Models.Entities
{
    public class employee
    {
        [Key]
        public Guid empId { get; set; }= Guid.NewGuid();
      
        [StringLength(50)]
        public  required string empName { get; set; }
       
        public required string empCode {  get; set; }
       
        public required string empEmail {  get; set; }

        //this is the foreign key for the employee 
        public Guid RoleId { get; set; }

        [ForeignKey("RoleId")]
        public role Role { get; set; }

        public Guid DepartmentId { get; set; }
        [ForeignKey(" DepartmentId")]
        public departments Department { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
