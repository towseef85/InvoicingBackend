using AutoMapper;
using Invoicing.Contracts;
using Invoicing.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Implementation
{
    public class Wrapper :IWrapper
    {
        private readonly SqlContext _sqlContext;
        private readonly IMapper _mapper;

        public Wrapper(SqlContext sqlContext, IMapper mapper)
        {
            _sqlContext = sqlContext;
            _mapper = mapper;
        }
        public ICountryBL CountryBL => new CountryBL( _sqlContext, _mapper);
        public ICityBL CityBL => new CityBL(_sqlContext, _mapper);

        public IInventoryItemBL InventoryItemBL => new InventoryItemBL(_sqlContext, _mapper);

        public ICustomerBL CustomerBL => new CustomerBL(_sqlContext, _mapper);
    }
}
