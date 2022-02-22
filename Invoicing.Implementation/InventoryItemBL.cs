using AutoMapper;
using Invoicing.Contracts;
using Invoicing.Models.Api;
using Invoicing.Models.Domain;
using Invoicing.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Implementation
{
    public class InventoryItemBL : IInventoryItemBL
    {
        private readonly SqlContext _repository;
        private readonly IMapper _mapper;

        public InventoryItemBL(SqlContext repository, IMapper mapper)
        {   
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> AddAsync(PostInventoryItemDto postInventoryItemDto)
        {
            _repository.InventoryItems.Add(_mapper.Map<InventoryItem>(postInventoryItemDto));
            var result = await _repository.SaveChangesAsync() > 0;
            if (result) return true;
            return false;
        }

        public async Task<List<GetInventoryItemsDto>> GetAsync()
        {
            var InventoryItems = await _repository.InventoryItems.ToListAsync();
            var InventoryItemList = _mapper.Map<List<GetInventoryItemsDto>>(InventoryItems);
            return InventoryItemList;
        }
    }
}
