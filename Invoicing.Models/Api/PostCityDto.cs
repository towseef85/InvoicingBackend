using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Models.Api
{
    public class PostCityDto
    {
        public Guid Id { get; set; }
        [Required]
        [JsonProperty("cityCode")]
        public string CityCode { get; set; }
        [Required]
        [JsonProperty("englishTitle")]
        public string EnglishTitle { get; set; }
        [Required]
        [JsonProperty("arabicTitle")]
        public string ArabicTitle { get; set; }
        [Required]
        [JsonProperty("countryId")]
        public Guid CountryId { get; set; }
    }
}
