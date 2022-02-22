using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Models.Domain
{
    public class Country
    {
        public Guid Id { get; set; }
        public string CountryCode { get; set; }
        public string EnglishTitle { get; set; }
        public string ArabicTitle { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
