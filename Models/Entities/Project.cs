using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Employee_Main.Models.Entities
{
    public class Project
    {
        [Key]
        public Guid ProjectId { get; set; } = Guid.NewGuid();

        public required string ProjectName {  get; set; }

        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        public Guid clientId { get; set; }
        [ForeignKey("clientId")]
        public Client client { get; set; } 

        public Guid empId { get; set; }
        [ForeignKey("empId")]
        public employee emp {  get; set; }

    }
}
//empName: string;
//empId: string;
//empCode: string;
//empEmailId: string;
//empDesignation: string;
//projectName: string;
//startDate: string;
//expectedEndDate: string;
//clientName: string;
//clientProjectId: number;