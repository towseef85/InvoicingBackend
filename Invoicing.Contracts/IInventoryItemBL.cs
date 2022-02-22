using Invoicing.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Contracts
{
    public interface IInventoryItemBL
    {
        Task<List<GetInventoryItemsDto>> GetAsync();
        Task<bool> AddAsync(PostInventoryItemDto postInventoryItemDto);
    }
}
