using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Domain.Models;
using Project.Domain.Services;

namespace Project.Http.Controllers
{
    [Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme)] 
    [Route("api/personal")]
    [ApiController]
    [Produces("application/json")]
    public class PersonalController : ControllerBase
    {
        private readonly EmployeeDataService _service = new EmployeeDataService();

        [HttpGet]
        public ActionResult<List<Personal>> GetAllCommands()
        {

            var items = _service.PersonalGetDataList();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetPersonal(int id)
        {
            var item = _service.PersonalGetData(id);
            if (item != null)
            {
                return Ok(item);

            }

            return NotFound();
        }


        [HttpPost("update")]
        public ActionResult<Employee> UpdatePersonal(Employee employee)
        {
            var item = _service.UpdateCommand(employee);
            if (item != null)
            {
                return Ok(item);

            }

            return NotFound();
        }




        [HttpPost("create")]
        public ActionResult<Employee> CreatePersonal(Employee employee)
        {
            _service.InsertCommand(employee);
            return Ok(employee);
        }


        [HttpPost("delete")]
        public ActionResult<Employee> DeletePersonal(Employee employee)
        {
            _service.DeleteCommand(employee);
            return Ok(employee);
        }

    }
}

