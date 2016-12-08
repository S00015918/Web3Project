using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProject.Models;

namespace WebProject
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Master.AddCurrentPage("Home");
            }

            WebClient wc = new WebClient();
            string connectionString = WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection myConnection = new SqlConnection(connectionString);

            // Count the number of rows in the table
            int rowCnt = RowCount();

            for (int i = 1; i <= rowCnt; i++)
            {
                DataView productsTable = (DataView)
                dsProducts.Select(DataSourceSelectArguments.Empty);
                productsTable.RowFilter = string.Format("ProductID = '{0}'", i); // Set the ProductId = i

                DataRowView row = productsTable[0];

                // create a new product object called poster and load with data from row
                Product poster = new Product();
                poster.ProductID = row["ProductID"].ToString();
                poster.ProductName = row["ProductName"].ToString();
                var json = wc.DownloadString("https://www.omdbapi.com/?t=" + poster.ProductName);

                // Create a jobject from the parsed Json
                JObject jProduct = JObject.Parse(json);

                //Take the image part from the json
                string image = (string)jProduct["Poster"];

                SqlCommand cmd = new SqlCommand("Update Product set ImageFile = @ImageFile where @id =" + poster.ProductID);

                cmd.Parameters.AddWithValue("@ImageFile", poster.ImageFile);


                if (myConnection.State == ConnectionState.Closed)
                {
                    myConnection.Open();
                }
                //cmd.ExecuteNonQuery();

                myConnection.Close();

            }

        }

        //This code is also required to count rows in the product table
        private int RowCount()
        {
            int data = 0;
            string query = "Select * From Product";
            DataSet dataSet = new DataSet();
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(dataSet, "Product");

                        data = dataSet.Tables["Product"].Rows.Count;


                    }
                }
            }
            return data;

        }

        public void AddToCart()
        {
            if (Page.IsValid)
            {
                //get cart from session and selected item from cart
                CartItemList cart = CartItemList.GetCart();
                CartItem cartItem = cart[0];

                //if item isn’t in cart, add it; otherwise, increase its quantity
                if (cartItem == null)
                {
                    //cart.AddItem(selectedProduct,selectedProduct.Price);
                }
                else
                {
                    //cartItem.AddQuantity(Convert.ToInt32(txtQuantity.Text));
                }
                Response.Redirect("Cart.aspx");
            }
        }

    }
}