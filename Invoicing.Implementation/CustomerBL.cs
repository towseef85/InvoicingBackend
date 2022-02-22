using AutoMapper;
using Invoicing.Contracts;
using Invoicing.Models.Api.Customer;
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
    public class CustomerBL : ICustomerBL
    {
        private readonly SqlContext _repository;
        private readonly IMapper _mapper;

        public CustomerBL(SqlContext repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> AddAsync(PostCustomerDto postCustomerDto)
        {
            _repository.Customers.Add(_mapper.Map<Customer>(postCustomerDto));
            var result = await _repository.SaveChangesAsync() > 0;
            if (result) return true;
            return false;
        }

        public async Task<List<GetCustomersDto>> GetAsync()
        {
            var customers = await _repository.Customers.ToListAsync();
            var customerList = _mapper.Map<List<GetCustomersDto>>(customers);
            return customerList;
        }
    }
}
