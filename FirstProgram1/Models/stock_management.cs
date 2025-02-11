using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class stock_management
    {
        public int product_available;
        public int product_price;
        public int product_sales;
        public int product_sold;

        [Required]
        public string Product_Name { get; set; }
        
        [Required]
        public string Product_Category { get; set; }

        [Required]
        public string Product_Description { get; set; }

        [Required]
        public int Product_Quantity
        {
            get => product_available;
            set => product_available = value;
        }
        [Required]
        public int Product_Sales
        {
            get => product_sales;
            set => product_sales = value;
        }

        [Required]
        public int Product_Sold
        {
            get => product_sold;
            set => product_sold = value;
        }

        [Required]
        public int Product_Price
        {
            get => product_price;
            set => product_price = value;
        }

    }
}
