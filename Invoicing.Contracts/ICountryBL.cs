using Invoicing.Models;
using Invoicing.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Invoicing.Contracts
{
    public interface ICountryBL
    {
        Task <List<GetCountriesDto>> GetAsync();
        Task<bool> AddAsync(PostCountryDto postCountryDto);
    }
}
