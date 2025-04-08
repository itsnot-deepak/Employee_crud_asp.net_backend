using Employee_Main.Data;
using Employee_Main.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employee_Main.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context; // we are creating an context for the database here which will be used to make changes to the database 

        public EmployeeRepository(AppDbContext context)
        {
            _context = context; // here we are injecting the database 
        }
        public async Task<IEnumerable<role>> GetAllRoleAsyncRepo()
        {
            return await _context.Role.ToListAsync(); // returning an list from the database        
        }
        public async Task<IEnumerable<departments>> GetAllDeptsAsyncRepo()
        {
            return await _context.Department.ToListAsync();
        }

        public async Task<IEnumerable<Client>> GetAllClientsAsyncRepo()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task DeleteClientAsyncRepo(Guid Clientid) // this method doesn't return anything and just deletes the client 
        {
            var client = await _context.Clients.FindAsync(Clientid); // first check if the client exist , if yes then delete 

            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();

            }
        }

        public async Task AddClientAsyncRepo(Client client)
        {
            await _context.Clients.AddAsync(client);
            await _context.SaveChangesAsync();
        }
    }
}
