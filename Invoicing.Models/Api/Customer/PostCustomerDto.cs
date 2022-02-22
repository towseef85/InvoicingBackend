using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Models.Api.Customer
{
    public class PostCustomerDto
    {
        public Guid Id { get; set; }

        [Required]
        [JsonProperty("customerCode")]
        public string CustomerCode { get; set; }
        [Required]
        [JsonProperty("englishName")]
        public string EnglishName { get; set; }
        [Required]
        [JsonProperty("arabicName")]
        public string ArabicName { get; set; }
        [Required]
        [JsonProperty("mobile")]
        public string Mobile { get; set; }
        [Required]
        [JsonProperty("email")]
        public string Email { get; set; }
        [Required]
        [JsonProperty("countryId")]
        public Guid CountryId { get; set; }
        [Required]
        [JsonProperty("cityid")]
        public Guid CityId { get; set; }
        [Required]
        [JsonProperty("address1")]
        public string Address1 { get; set; }
        [JsonProperty("address2")]
        public string Address2 { get; set; }
        [JsonProperty("address3")]
        public string Address3 { get; set; }
    }
}
