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
    public class CityBL : ICityBL
    {
        private readonly SqlContext _repository;
        private readonly IMapper _mapper;

        public CityBL(SqlContext repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> AddAsync(PostCityDto postCityDto)
        {
            _repository.Cities.Add(_mapper.Map<City>(postCityDto));
            var result = await _repository.SaveChangesAsync() > 0;
            if (result) return true;
            return false;
        }

        public async Task<List<GetCitiesDto>> GetAsync()
        {
            var Cities = await _repository.Cities.ToListAsync();
            var CityList = _mapper.Map<List<GetCitiesDto>>(Cities);
            return CityList;
        }
    }
}
