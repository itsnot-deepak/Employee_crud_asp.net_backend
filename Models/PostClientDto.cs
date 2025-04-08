using System.ComponentModel.DataAnnotations;

namespace Employee_Main.Models
{
    public class PostClientDto
    {
        public required string contactPersonName { get; set; }
        public required string companyName { get; set; }
        [MaxLength(1000)]
        public required string address { get; set; }
        public required string city { get; set; }
        public required string pincode { get; set; }
        public required string state { get; set; }
        public required int employeeStrength { get; set; }

        public string? gstNo { get; set; }
        public string? contactNo { get; set; }
        public string? regNo { get; set; }
    }
}
