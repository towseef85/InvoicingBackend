using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Models.Api
{
    public class GetCitiesDto
    {
        public Guid Id { get; set; }
        public string CityCode { get; set; }
        public string EnglishTitle { get; set; }
        public string ArabicTitle { get; set; }
        public Guid CountryId { get; set; }
    }
}
