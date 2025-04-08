using Employee_Main.Data;
using Employee_Main.Models;
using Employee_Main.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Employee_Main.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //private readonly AppDbContext DbContext; this is the context for the db in the normal case 

        // this is the dependency injection for the database
        //public EmployeeController( AppDbContext dbcontext)  //this is the normal way of doing the api call but we are using the repo structure here 
        //{
        //    DbContext = dbcontext;
        //}

        // we are using the repo structure from here 

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService) // injecting the service in the controller 
        {
            _employeeService = employeeService;
            
        }
        //[HttpGet]
        //public IActionResult GetAllRoles()
        //{
        //    //var allRole = DbContext.Role.ToList();
        //    //return Ok(allRole);
        //}
        [HttpGet]
        [Route("Roles")]
        public async Task<IActionResult> GetAllRoles()
        {
            var res = await _employeeService.GetAllRoleServ();

            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [HttpGet]
        [Route("Departments")]
        public async Task<IActionResult> GetAllDepartment()
        {
            var res = await _employeeService.GetAllDeptsServ();

            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }


        [HttpGet]
        [Route("Clients")]
        public async Task<IActionResult> GetAllClients()
        {
            var res = await _employeeService.GetAllClientsServ();

            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [HttpDelete("{ClientId}")]

        public async Task DeleteClientById(Guid ClientId)
        {
            await _employeeService.DeleteClientsByIDServ(ClientId);
        }


        // in the http put the whole process is reverse we get the data from the body of the http request 
        // then we create an dto object using the data recived in the request then this data is used to
        // make an client object to store in the db and is finally stored in the database 


        // this function returns an Iactionresult which is the ok command and nothing else 
        [HttpPost("Clients")] // here i have put the clients in the bracket because in the angular i have put the api call as +clients,obj remove the clients and it will work fine 
        public async Task<IActionResult> AddClient([FromBody] PostClientDto clinetdto)
        {
            return Ok(await _employeeService.AddClientServ(clinetdto));  // this is just simply getting back the dto that it has sent 
        }
    }
}
