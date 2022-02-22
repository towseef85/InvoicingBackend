using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Contracts
{
    public interface IWrapper
    {
        ICountryBL CountryBL { get; }
        ICityBL CityBL { get; }
        IInventoryItemBL InventoryItemBL { get; }
        ICustomerBL CustomerBL { get; }
    }
}
