using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebProject.Models
{

    [Table("Product")]
    public class Product
    {
        [Key]
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
        public string Genre { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }
    }
}