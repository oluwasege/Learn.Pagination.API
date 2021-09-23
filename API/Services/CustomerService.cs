using API.Data;
using API.Entities;
using API.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;
        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Customer>> GetAllCustomers()
        {
            var result = await _context.Customers.ToListAsync();
            return result;
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            var result = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
    }
}
