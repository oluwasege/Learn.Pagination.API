using API.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Interface
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter fiflter, string route);
    }
}
