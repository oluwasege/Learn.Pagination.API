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
    public class Customer : ControllerBase
    {
        private readonly ICustomerService service;
        public Customer(ICustomerService customerService)
        {
            service = customerService;
        }
        [HttpGet]
        [Route("allcustomer")]
        public async Task<IActionResult>GetAllCustomers()
        {
            var result = await service.GetAllCustomers();
            return Ok(result);
        }

        [HttpGet]
        [Route("customer")]
        public async Task<IActionResult>GetCustomerById([FromQuery]int id)
        {
            var result = await service.GetCustomerById(id);
            return Ok(result);
        }
    }
}
