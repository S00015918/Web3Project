using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }

        public DateTime OrderDate { get; set; }
        public int orderQuantity { get; set; }
        public bool Shipped { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

    }
}