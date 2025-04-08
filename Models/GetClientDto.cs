namespace Employee_Main.Models
{
    public class GetClientDto
    {
        public required string contactPersonName {  get; set; }
        public required string companyName { get; set; }
        public required string contactNo { get; set; }
        public required string city { get; set; }

        public required Guid clientId { get; set; }

    }
}
