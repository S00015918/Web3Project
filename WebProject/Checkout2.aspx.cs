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
    public partial class Checkout2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Master.HeaderText = "Customer Bank Details";

                Master.AddBreadcrumbLink("/Default.aspx", "Home");
                Master.AddCurrentPage("Credit Card Details");
            }
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                if (rblShipping.SelectedValue == "1")
                {
                    var customer = (Customer)Session["Customer"];
                    customer.ShippingMethod = "3";
                    customer.CardType = ddlCardType.SelectedValue;
                    customer.CardNumber = txtCardNumber.Text;
                    customer.ExpirationDate = txtExpiration.Text;
                }

                if (rblShipping.SelectedValue == "2")
                {
                    var customer = (Customer)Session["Customer"];
                    customer.ShippingMethod = "2";
                    customer.CardType = ddlCardType.SelectedValue;
                    customer.CardNumber = txtCardNumber.Text;
                    customer.ExpirationDate = txtExpiration.Text;
                }

                if (rblShipping.SelectedValue == "3")
                {
                    var customer = (Customer)Session["Customer"];
                    customer.ShippingMethod = "5";
                    customer.CardType = ddlCardType.SelectedValue;
                    customer.CardNumber = txtCardNumber.Text;
                    customer.ExpirationDate = txtExpiration.Text;
                }

                Session.Remove("Cart");
                Response.Redirect("~/Confirmation.aspx");

            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session.Remove("Cart");
            Session.Remove("Customer");

            string url = ConfigurationManager.AppSettings["UnSecurePath"] + "Order.aspx";
            Response.Redirect(url);

        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            string url = ConfigurationManager.AppSettings["SecurePath"] + "Confirmation.aspx";
            Response.Redirect(url);

        }
    }
}