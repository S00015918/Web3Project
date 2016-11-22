using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProject.Models;

public class CartItem
{
    public CartItem() { }

    public CartItem(Product product, int quantity, decimal price)
    {
        this.Product = product;
        this.Quantity = quantity;
        this.UnitPrice = price;
    }

    public Product Product { get; set; }
    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public void AddQuantity(int quantity)
    {
        this.Quantity += quantity;
    }

    public string Display()
    {
        decimal totalPrice = Quantity * UnitPrice;

        string displayString = string.Format("{0} ({1} at {2}. Total Cost: {3})",
            Product.ProductName, 
            Quantity.ToString(),
            Product.Price.ToString("c"),
            totalPrice.ToString("c")
        );
        return displayString;
    }
}
