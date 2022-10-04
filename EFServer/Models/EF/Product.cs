using System;
using System.Collections.Generic;

namespace EFServer.Models.EF
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductCategory { get; set; } = null!;
        public string? ProductDescription { get; set; }
        public string? ProductImgUrl { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQty { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
