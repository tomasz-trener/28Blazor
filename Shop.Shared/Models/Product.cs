using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public double Price { get; set; } // domyślnie mapuje na deciaml(18,2) w bazie danych

        public string Description { get; set; }

        public string Barcode { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
