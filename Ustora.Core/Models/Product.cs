using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ustora.Core.Models
{
    public class Product:BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Description_html { get; set; }
        public List<byte[]> ProductImages { get; set; }

        public int ItemRating { get; set; }
        public int PriceFrom { get; set; }
        public int PriceTo { get; set; }
        public int SortProduct { get; set; }
        public bool IsActiveProduct{ get; set; }
        public bool CanBeInstallment{ get; set; }
        public Category Category { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public ShippingCart ShippingCart { get; set; }
        [ForeignKey("ShippingCart")]
        public int ShippingCartId { get; set; }
        public Installment Installment { get; set; }
        [ForeignKey("Installment")]
        public int InstallmentId { get; set; }
        public Review Review { get; set; }
        [ForeignKey("Review")]
        public int ReviewId { get; set; }
        public Discount Discount { get; set; }
        [ForeignKey("Discount")]
        public int DiscountId { get; set; }
    }
}
