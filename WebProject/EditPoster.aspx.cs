using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Imaging;

namespace WebProject
{
    public partial class EditPoster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }//end pageLoad



        protected void btnApplyChanges_Click(object sender, EventArgs e)
        {
            filterListFinal_SelectedIndexChanged(sender, e);
            sizeListFinal_SelectedIndexChanged(sender, e);

        }//end btnapply

        protected void filterListFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterList.SelectedValue == "1")
            {
                imageDisplay.CssClass = "image1";
            }
            else if (filterList.SelectedValue == "2")
            {
                imageDisplay.CssClass = "image2";
            }
            else if (filterList.SelectedValue == "3")
            {
                imageDisplay.CssClass = "image3";
            }
            else if (filterList.SelectedValue == "4")
            {
                imageDisplay.CssClass = "image4";
            }
            else if (filterList.SelectedValue == "5")
            {
                imageDisplay.CssClass = "image5";
            }
            else if (filterList.SelectedValue == "6")
            {
                imageDisplay.CssClass = "image6";
            }
            else if (filterList.SelectedValue == "7")
            {
                imageDisplay.CssClass = "image7";
            }
            else if (filterList.SelectedValue == "8")
            {
                imageDisplay.CssClass = "image8";
            }
            else
            {
                imageDisplay.CssClass = "";
            }

        }//end filterlistfinal_selectedindexchanged

        protected void sizeListFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //test values
            if (sizeList.SelectedValue == "1")
            {
                imageDisplay.Width = 400;
                imageDisplay.Height = 200;
            }
            else if (sizeList.SelectedValue == "2")
            {
                imageDisplay.Height = 800;
                imageDisplay.Width = 600;
            }
            else if (sizeList.SelectedValue == "3")
            {
                imageDisplay.Width = 600;
                imageDisplay.Height = 400;
            }
            else if (sizeList.SelectedValue == "4")
            {
                imageDisplay.Height = 600;
                imageDisplay.Width = 800;
            }
            else
            {
                imageDisplay.Height = 500;
                imageDisplay.Width = 800;
            }


        }//end sizelist selected index changed



    } //end class
}//end Namespace