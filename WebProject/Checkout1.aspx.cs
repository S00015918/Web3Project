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
            if (!IsPostBack)
            {
                Master.HeaderText = "Customer Personal Details";

                Master.AddBreadcrumbLink("/Default.aspx", "Home");
                Master.AddBreadcrumbLink("/Cart.aspx", "Cart");
                Master.AddCurrentPage("Customer Details");

                bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    Firstname.Visible = false;
                    Surname.Visible = false;
                    lblFirstname.Visible = false;
                    lblSurname.Visible = false;
                }
            }
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (IsValid)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    Firstname.Visible = false;
                    Surname.Visible = false;

                    //ApplicationDbContext ctx = new ApplicationDbContext();
                    //ctx.Customers.Add(new Customer
                    //{
                    //    City = City.Text,
                    //    County = County.Text

                    //});
                    //ctx.SaveChanges();
                    var customer = new Customer();

                    customer.EmailAddress = Email.Text;
                    customer.Address = Address.Text;
                    customer.City = City.Text;
                    customer.County = County.Text;
                    customer.Phone = Phone.Text;
                    Session["Customer"] = customer;
                    Response.Redirect("~/Checkout2.aspx");
                }
                else
                {
                    var customer = new Customer();
                    customer.FirstName = Firstname.Text;
                    customer.LastName = Surname.Text;
                    customer.EmailAddress = Email.Text;
                    customer.Address = Address.Text;
                    customer.City = City.Text;
                    customer.County = County.Text;
                    customer.Phone = Phone.Text;
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