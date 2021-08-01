using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement_API_JobanSandhu.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }

        public List<StockMaintain> StockMaintains { get; set; }
    }
}
