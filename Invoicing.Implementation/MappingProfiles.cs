using AutoMapper;
using Invoicing.Models.Api;
using Invoicing.Models.Api.Customer;
using Invoicing.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Implementation
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<PostCountryDto, Country>();
            CreateMap<Country, GetCountriesDto>();
            CreateMap<PostCityDto, City>();
            CreateMap<City, GetCitiesDto>();
            CreateMap<PostInventoryItemDto, InventoryItem>();
            CreateMap<InventoryItem, GetInventoryItemsDto>();
            CreateMap<Customer, GetCustomersDto>();
            CreateMap<PostCustomerDto, Customer>();
        }
    }
}
