using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ustora.Core.Models
{
    public class ShippingCart: BaseClass
    {
       
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
