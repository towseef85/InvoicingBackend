using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Models.Api.Customer
{
    public class GetCustomersDto
    {
        public Guid Id { get; set; }
        public string CustomerCode { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public Guid CountryId { get; set; }
        public Guid CityId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
    }
}
