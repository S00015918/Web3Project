using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProject.Models;

namespace WebProject
{
    public partial class Products : System.Web.UI.Page
    {
        private Product selectedProduct;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) ddlProducts.DataBind();
            selectedProduct = this.GetSelectedProduct();
            lblProductName.Text = selectedProduct.ProductName;
            lblUnitPrice.Text = selectedProduct.Price.ToString("c") + " each";
            imgProduct.ImageUrl = selectedProduct.ImageFile;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //get cart from session and selected item from cart
                CartItemList cart = CartItemList.GetCart();
                CartItem cartItem = cart[selectedProduct.ProductID];

                //if item isn’t in cart, add it; otherwise, increase its quantity
                if (cartItem == null)
                {
                    cart.AddItem(selectedProduct,
                                 Convert.ToInt32(txtQuantity.Text), selectedProduct.Price);
                }
                else
                {
                    cartItem.AddQuantity(Convert.ToInt32(txtQuantity.Text));
                }
                Response.Redirect("Cart.aspx");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }
        protected void btnCart_Click(object sender, EventArgs e)
        {

        }

        private Product GetSelectedProduct()
        {
            //get row from AccessDataSource based on value in dropdownlist
            DataView productsTable = (DataView)
                dsProducts.Select(DataSourceSelectArguments.Empty);
            productsTable.RowFilter =
                "ProductID = '" + ddlProducts.SelectedValue + "'";
            DataRowView row = productsTable[0];

            //create a new product object and load with data from row
            Product p = new Product();
            p.ProductID = row["ProductID"].ToString();
            p.ProductName = row["ProductName"].ToString();
            p.Price = (decimal)row["Price"];
            p.QuantityInStock = (int)row["QuantityInStock"];
            p.ImageFile = row["ImageFile"].ToString();
            return p;
        }
    }
}