using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    [Table("ProductsDelivered")]
    public class ProductsDelivered
    {
        [Key]
        public int DeliveryID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}