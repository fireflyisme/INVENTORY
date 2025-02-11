using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    internal class Restocking
    {
        public int product_quantity;
        public int product_price;
        

        [Required]
        public string Product_Name { get; set; }


        [Required]
        public string Product_Seller { get; set; }


        [Required]
        public string Product_Category { get; set; }

        [Required]
        public int Product_Quantity
        {
            get => product_quantity;
            set => product_quantity = value;
        }
        
        [Required]
        public int Product_Price
        {
            get => product_price;
            set => product_price = value;
        }
       
        [Required]
        public string Product_Deliverydate { get; set; }




    }
}
