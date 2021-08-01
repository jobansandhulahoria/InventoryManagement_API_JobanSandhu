using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement_API_JobanSandhu.Models
{
    public class StockMaintain
    {
        public int ID { get; set; }
        
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int SoldItems { get; set; }
        public int LeftItems { get; set; }
    }
}
