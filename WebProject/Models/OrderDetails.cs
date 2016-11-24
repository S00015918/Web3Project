using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    [Table("OrderDetails")]
    public class OrderDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailId { get; set; }
        [ForeignKey("order"), Column(Order = 0)]
        public int OrderID { get; set; }
        [ForeignKey("product"), Column(Order = 1)]
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public virtual Order order { get; set; }
        public virtual Product product { get; set; }

        public static OrderDetails GetCart()
        {
            OrderDetails cart = (OrderDetails)HttpContext.Current.Session["Cart"];
            if (cart == null)
                HttpContext.Current.Session["Cart"] = new OrderDetails();
            return (OrderDetails)HttpContext.Current.Session["Cart"];
        }

    }
}