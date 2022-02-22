using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Models.Domain
{
    public class InventoryItem
    {
        public Guid Id { get; set; }
        public string ItemCode { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public long Price { get; set; }
        public long VatPercentage { get; set; }
    }
}
