using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hpc_technical_summer_2023_order_system.Models
{
    public class Product
    {
        [Key] // not neccessary if called "Id", with uppercase I and lowercase d
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "DECIMAL(6, 2)")] // decimal(6,2)???
        public decimal Price { get; set; }
    }
}
