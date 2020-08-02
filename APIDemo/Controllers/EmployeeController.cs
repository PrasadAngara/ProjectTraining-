using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo.Models;
using APIDemo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo.Controller
{
    [Route("api/[controllers]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeRepository repository = new EmployeeRepository();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(repository.GetAll());
        }
        [HttpGet]
        [Route("GetById/{1}")]
        public IActionResult Get(string EmpId)
        {
            return Ok(repository.GetById(EmpId));
        }
        [HttpPost]
        [Route("Add")]
        public addDummy Add(Employee employee)
        {
            repository.Add(employee);
            return Ok();
        }
        [HttpPut]
        [Route("Updateandadd")]
        public dummy Update(Employee employee)
        // {
        //     repository.Update(employee);
        //     return Ok();
          something.Update(employee);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{2}")]
        public IActionResult Delete(string EmpId)
        {
            repository.Delete(EmpId);
            return Ok("Record Deleted");
        }

    }
}