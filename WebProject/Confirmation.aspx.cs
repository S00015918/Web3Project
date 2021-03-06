﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProject.Models;

namespace WebProject
{
    public partial class Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            var customer = (Customer)Session["Customer"];
            var deliveryDate = customer.ShippingMethod.ToString();
            var date = DateTime.Today.AddDays(1).ToShortDateString();
            lblConfirm.Text = $"Thank you for your order, {customer.FirstName}! It will arrive in {deliveryDate} days.";
        }
        protected void btnContinue_Click(object sender, EventArgs e)
        {
            string url = ConfigurationManager.AppSettings["UnSecurePath"] + "Default.aspx";
            Response.Redirect(url);
        }
    }
}