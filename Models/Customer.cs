using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hpc_technical_summer_2023_order_system.Models
{
    public class Customer
    {

        [Key]
        public int ID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string? Address { get; set; }

        public string? Phone { get; set; }


        // Indicates a one-to-many relationship from customers to orders
        public ICollection<Order> Orders { get; set; } = null!;
    }
}
