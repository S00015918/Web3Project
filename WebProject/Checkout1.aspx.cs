using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProject.Models;

namespace WebProject
{
    public partial class Checkout1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (IsValid)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    txtFirstName.Visible = false;
                    txtLastName.Visible = false;

                    ApplicationDbContext ctx = new ApplicationDbContext();
                    ctx.Customers.Add(new Customer
                    {
                        City = txtCity.Text,
                        County = txtCounty.Text
                        
                    });
                    ctx.SaveChanges();
                }
                else
                {
                    var customer = new Customer();
                    customer.FirstName = txtFirstName.Text;
                    customer.LastName = txtLastName.Text;
                    customer.EmailAddress = txtEmail.Text;
                    customer.Address = txtAddress.Text;
                    customer.City = txtCity.Text;
                    customer.County = txtCounty.Text;
                    customer.Phone = txtPhone.Text;
                    Session["Customer"] = customer;
                    Response.Redirect("~/Checkout2.aspx");
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session.Remove("Cart");

            string url = ConfigurationManager.AppSettings["UnSecurePath"] + "Order.aspx";
            Response.Redirect(url);

            //Response.Redirect("~/Order.aspx");
        }
    }
}