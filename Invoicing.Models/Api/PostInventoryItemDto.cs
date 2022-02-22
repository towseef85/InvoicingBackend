using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Models.Api
{
    public class PostInventoryItemDto
    {
        public Guid Id { get; set; }

        [Required]
        [JsonProperty("itemCode")]
        public string ItemCode { get; set; }
        [Required]
        [JsonProperty("englishName")]
        public string EnglishName { get; set; }
        [Required]
        [JsonProperty("arabicName")]
        public string ArabicName { get; set; }
        [Required]
        [JsonProperty("price")]
        public long Price { get; set; }
        [Required]
        [JsonProperty("vatPercentage")]
        public long VatPercentage { get; set; }
    }
}
