using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entites
{
    public class CustomerReservation
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Branch { get; set; }
        public string SubmitedBy { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public decimal DownPayment { get; set; }
        public DateTime Date { get; set; }

    }
}
