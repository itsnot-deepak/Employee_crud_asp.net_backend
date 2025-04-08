using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Employee_Main.Models.Entities
{
    public class Client
    {
        [Key]
        public Guid clientId { get; set; }= Guid.NewGuid();
        public required string contactPersonName {  get; set; }
        public required string companyName {  get; set; }
        [MaxLength(1000)]
        public required string address {  get; set; }
        public required string city { get; set; }
        public required string pincode { get; set; }
        public required string state { get; set; }
        public int employeeStrength {  get; set; }

        public  string? gstNo { get; set; }
        public  string? contactNo { get; set; }
        public  string? regNo { get; set; }

        public ICollection<Project> Projects { get; set; }

    }
}
//clientId: number
//contactPersonName: string
//companyName: string
//address: string
//city: string
//pincode: string
//state: string
//employeeStrength: number
//gstNo: string
//contactNo: string
//regNo: string