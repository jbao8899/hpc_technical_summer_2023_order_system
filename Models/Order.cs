using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hpc_technical_summer_2023_order_system.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        public DateTime OrderPlaced { get; set; }

        public DateTime? OrderFulfilled { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; } = null!;
        public ICollection<Order> OrderDetails { get; set; } = null!;
    }
}
