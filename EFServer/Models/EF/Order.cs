using System;
using System.Collections.Generic;

namespace EFServer.Models.EF
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrdersId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderAmount { get; set; }
        public string UserId { get; set; } = null!;

        public virtual AspNetUser User { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
