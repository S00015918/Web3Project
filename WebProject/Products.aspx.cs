using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            // bind dropdown and set breadcrumb on first load;    
            if (!IsPostBack)
            {
                ddlProducts.DataBind();
                Master.HeaderText = "Posters";
                Master.AddBreadcrumbLink("/Default.aspx", "Home");
                Master.AddCurrentPage("Products");
            }

            // get and show product data on every load   

            selectedProduct = this.GetSelectedProduct();
            lblProductName.Text = selectedProduct.ProductName;
            lblUnitPrice.Text = selectedProduct.Price.ToString("c") + " each";
            imgProduct.ImageUrl = selectedProduct.ImageFile;
            dgPoster.BackImageUrl = "Images/Products/" + selectedProduct.ImageFile;


            if (!String.IsNullOrEmpty(Request.QueryString["srch"]))
            {
                //perform search and display results
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                string query = "Select * from Product where (ProductName like '%' + @name + '%')";

                SqlCommand comm = new SqlCommand(query, con);
                comm.Parameters.AddWithValue("@name", query).Value = (Request.QueryString["srch"]);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comm;
                DataSet ds = new DataSet();

                da.Fill(ds, "ImageFile");
                dgPoster.DataSource = ds;

                dgPoster.DataBind();

                con.Close();
            }
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //get cart from session and selected item from cart
                CartItemList cart = CartItemList.GetCart();
                CartItem cartItem = cart[selectedProduct.ProductID];

                //if item isn’t in cart, add it; otherwise, increase its quantity
                if (!string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    if (cartItem == null)
                    {
                        cart.AddItem(selectedProduct,
                                 Convert.ToInt32(txtQuantity.Text), selectedProduct.Price);
                    }
                    else
                    {
                        cartItem.AddQuantity(Convert.ToInt32(txtQuantity.Text));
                    } 
                }
                else
                {
                    if (cartItem == null)
                    {
                        int quantity = 1;
                        cart.AddItem(selectedProduct,
                        quantity, selectedProduct.Price);
                    }
                    else
                    {
                        cartItem.AddQuantity(Convert.ToInt32(txtQuantity.Text));
                    }
                }
                
                Response.Redirect("Cart.aspx");
            }
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {

        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgPoster.Visible = false;
        }
    }
}