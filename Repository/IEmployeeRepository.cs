using Employee_Main.Models.Entities;

namespace Employee_Main.Repository
{
    public interface IEmployeeRepository
    {
        // this is the repository function for getting all the roles 
        Task<IEnumerable<role>> GetAllRoleAsyncRepo();
        // this is the repo to get back all the departments from the db 
        Task<IEnumerable<departments>> GetAllDeptsAsyncRepo();
        Task<IEnumerable<Client>> GetAllClientsAsyncRepo();

        // this is the repo function that is used to delete the clients 
        Task DeleteClientAsyncRepo(Guid Clientid);

        // this is the repo function to add the client into the list 

        Task AddClientAsyncRepo(Client client);

    }
}
