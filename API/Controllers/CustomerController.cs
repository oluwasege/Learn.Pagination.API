using API.Filter;
using API.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService service;
        public CustomerController(ICustomerService customerService)
        {
            service = customerService;
        }
        [HttpGet]
        public async Task<IActionResult>GetAllCustomers([FromQuery] PaginationFilter filter)
        {
            var result = await service.GetAllCustomers(filter);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>GetCustomerById(int id)
        {
            var result = await service.GetCustomerById(id);
            return Ok(result);
        }
    }
}
