using API.Data;
using API.Entities;
using API.Filter;
using API.Services.Interface;
using API.Wrappers;
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
        public async Task<PagedResponse<List<Customer>>> GetAllCustomers(PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var pagedData = await _context.Customers
                         .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                         .Take(validFilter.PageSize)
                         .ToListAsync();
            //var result = await _context.Customers.ToListAsync();
            var totlalRecords = await _context.Customers.CountAsync();
            var response = new PagedResponse<List<Customer>>(pagedData,validFilter.PageNumber,validFilter.PageSize);
            return response;
        }

        public async Task<Response<Customer>> GetCustomerById(int id)
        {
            
            var result = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
            var response = new Response<Customer>(result);
            return response;
        }
    }
}
