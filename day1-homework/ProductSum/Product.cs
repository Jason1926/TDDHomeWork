using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSum
{
    public class Product
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }

        public Product(int Id, int Cost, int Revenue, int SellPrice)
        {
            this.Id = Id;
            this.Cost = Cost;
            this.Revenue = Revenue;
            this.SellPrice = SellPrice;
        }
    }
}
