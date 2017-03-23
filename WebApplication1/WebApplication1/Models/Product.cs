using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int Price { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public ICollection<ItemDetails> Details { get; set; }
    }

    public class ItemDetails
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }


    public class OrderItemDetailsViewModel
    {
        public Order order { get; set; }
        public ItemDetails[] itemDetails { get; set; }
    }
}