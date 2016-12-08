using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.HeaderText = "About Us";

            Master.AddBreadcrumbLink("/Default.aspx", "Home");
            Master.AddCurrentPage("About Us");
        }
    }
}