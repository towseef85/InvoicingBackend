using Invoicing.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Contracts
{
    public interface ICityBL
    {
        Task<List<GetCitiesDto>> GetAsync();
        Task<bool> AddAsync(PostCityDto postCityDto);
    }
}
