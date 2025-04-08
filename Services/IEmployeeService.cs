using Employee_Main.Models;
using Employee_Main.Models.Entities;

namespace Employee_Main.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<GetRolesDto>> GetAllRoleServ(); // see that here we are using the dto instead of the actual data for the retrival 


        // service to get all the departments
        Task<IEnumerable<GetDepartmentDto>> GetAllDeptsServ();

        // service to get all the clients 
        Task<IEnumerable<GetClientDto>> GetAllClientsServ();
        
        // service to delete client using the guid 
        Task DeleteClientsByIDServ(Guid clientId);


        //this service is used to add the client , the argument in this is dto because we will be getting an dto object and then we are going
        //to map that dto object to the client object and then we store that client object to the database 

        Task<PostClientDto> AddClientServ(PostClientDto client);
    }
}
