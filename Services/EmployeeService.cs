using Employee_Main.Models;
using Employee_Main.Models.Entities;
using Employee_Main.Repository;

namespace Employee_Main.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            
        }
        public async Task<IEnumerable<GetRolesDto>> GetAllRoleServ()
        {
            var roles = await _employeeRepository.GetAllRoleAsyncRepo();

            return roles.Select(e => new GetRolesDto // this here is an linq projection 
            // here the .Select function goes thru every record in the roles and then for 
            // every record it is creating a new getRolesDto object and then we are using the {} initalization to set the role as e.role 
            {
                Role = e.Role,
                //Id=e.Id,  if i try to bring the id too then i get the error saying that the id is not in t
            });
            // at last the select returns an Ienumerable of all the dto  which is what we are wanting 
        }

        public async Task<IEnumerable<GetDepartmentDto>> GetAllDeptsServ()
        {
            var depts=await _employeeRepository.GetAllDeptsAsyncRepo();

            return depts.Select(e => new GetDepartmentDto { Department = e.DepartmentName });
            
        }

        public async Task<IEnumerable<GetClientDto>> GetAllClientsServ()
        {
            var clients=await _employeeRepository.GetAllClientsAsyncRepo();

            return clients.Select(e => new GetClientDto
            {
                contactPersonName = e.contactPersonName,
                companyName = e.companyName,
                contactNo = e.contactNo, // i had left the contact number to be left null 
                city = e.city,
                clientId = e.clientId,
            });
        }

        public  async Task DeleteClientsByIDServ(Guid ClientId)
        {
            await _employeeRepository.DeleteClientAsyncRepo(ClientId);

        }

        public async Task<PostClientDto> AddClientServ(PostClientDto client)
        {
            var cli = new Client
            {
               contactPersonName=client.contactPersonName,
               companyName=client.companyName,
               contactNo=client.contactNo,
               city=client.city,
               pincode=client.pincode,
               address=client.address,
               state=client.state,
               gstNo=client.gstNo,
               regNo=client.regNo,
               employeeStrength=client.employeeStrength,
            };

            await _employeeRepository.AddClientAsyncRepo(cli);
            return client;  // after calling the repo function we just simply return the same dto back , there is no use of that just like that 
        }
    }
}

