using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entites
{
    public class Prize
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
