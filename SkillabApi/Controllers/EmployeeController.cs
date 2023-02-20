
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SkillabApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillabApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private IEmployeeService _employeeService;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeesAsync()
        {

            var list = await _employeeService.GetEmployees();

            return StatusCode(StatusCodes.Status200OK, JsonConvert.SerializeObject(list));
        }



        [HttpPost]
        public async Task<IActionResult> AddHardcodedEmployees()
        {
           await _employeeService.AddHardCodedEmployees();
            return StatusCode(StatusCodes.Status200OK);
        }

        //[HttpGet]
        //public Employee GetById(int Id)
        //{

        //    return Employees.FirstOrDefault(e => e.Id == Id);
        //}
    }
}
