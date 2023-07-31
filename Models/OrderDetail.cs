using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hpc_technical_summer_2023_order_system.Models
{
    public class OrderDetail
    {
        [Key]
        public int ID { get; set; }

        public int Quantity { get; set; }

        public int ProductID { get; set; }

        public int OrderId { get; set; }

        public Order order { get; set; } = null!;

        public Product product { get; set; } = null!;
    }
}
