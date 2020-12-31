using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entites
{
    public class Product
    {
        public int ID { get; set; }
        public string  SerialNumber { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public bool Avalibality { get; set; }
        public decimal DownPayment { get; set; }
        public ICollection<Prize> Prizes { get; set; }
    }
}
