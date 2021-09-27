using API.Entities;
using API.Filter;
using API.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface ICustomerService
    {
        public Task<PagedResponse<List<Customer>>> GetAllCustomers(PaginationFilter filter);
        public Task<Response<Customer>> GetCustomerById(int id);
    }
}
