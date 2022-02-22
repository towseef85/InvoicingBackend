using AutoMapper;
using Invoicing.Contracts;
using Invoicing.Models;
using Invoicing.Models.Api;
using Invoicing.Models.Domain;
using Invoicing.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Implementation
{
    public class CountryBL : ICountryBL
    {
        private readonly SqlContext _repository;
        private readonly IMapper _mapper;

        public CountryBL(SqlContext repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetCountriesDto>> GetAsync()
        {
            var countries = await _repository.Countries.ToListAsync();
            var countryList = _mapper.Map<List<GetCountriesDto>>(countries);
            return countryList;
        }

        public async Task<bool> AddAsync(PostCountryDto postCountryDto)
        {
            _repository.Countries.Add(_mapper.Map<Country>(postCountryDto));
            var result = await _repository.SaveChangesAsync() >0;
            if (result) return true;
            return false;
            
        }

        
    }
}
