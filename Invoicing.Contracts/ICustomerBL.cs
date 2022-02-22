using Invoicing.Models.Api.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Contracts
{
    public interface ICustomerBL
    {
        Task<List<GetCustomersDto>> GetAsync();
        Task<bool> AddAsync(PostCustomerDto postCustomerDto);
    }
}
