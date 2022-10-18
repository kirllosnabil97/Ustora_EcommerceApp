using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ustora.Core.Models
{
    public class Discount : BaseClass
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public double Discount_Percentedge { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
