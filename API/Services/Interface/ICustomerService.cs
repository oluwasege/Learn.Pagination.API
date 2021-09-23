using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface ICustomerService
    {
        public Task<List<Customer>> GetAllCustomers();
        public Task<Customer> GetCustomerById(int id);
    }
}
