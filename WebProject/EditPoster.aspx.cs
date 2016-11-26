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

        protected void uploadImage_Click(object sender, EventArgs e)
        {
            if (posterUpload.HasFile)
            {
                string savePath = "E:/College/ThirdYear/Web Programming/WebProject/Web3Project-master/WebProject/Images/"; //Temporary until database is implemented!
                string fileName = posterUpload.FileName;
                string pathToCheck = savePath + fileName;
                string tempFileName = "";

                if (System.IO.File.Exists(pathToCheck))
                {
                    int counter = 2;

                    while (System.IO.File.Exists(pathToCheck))
                    {
                        tempFileName = counter.ToString() + fileName;
                        pathToCheck = savePath + tempFileName;
                        counter++;
                    }//end while

                    fileName = tempFileName;

                    outputLabel.Text = string.Format("Image uploaded as {0}!", fileName);
                    outputLabel.CssClass = "alert alert-success";
                    btnUpload.CssClass = "btn btn-primary disabled";

                }//end if
                else
                {
                    outputLabel.Text = "Image uploaded!";
                    outputLabel.CssClass = "alert alert-success";
                    btnUpload.CssClass = "btn btn-primary disabled";
                }//end else

                savePath += fileName;

                posterUpload.SaveAs(savePath);
                imageDisplay.ImageUrl = "Images/" + fileName;

            }//end if
            else
            {
                outputLabel.Text = "You must select an image!";
                outputLabel.CssClass = "alert alert-danger";
            }//end else

            filterListFinal_SelectedIndexChanged(sender, e);
            sizeListFinal_SelectedIndexChanged(sender, e);

        }//end uploadImage_Click




        protected void btnApplyChanges_Click(object sender, EventArgs e)
        {

        }//end btnapply

        protected void filterListFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterListFinal.SelectedValue == "1")
            {
                imageDisplay.CssClass = "image1";
            }
            else if (filterListFinal.SelectedValue == "2")
            {
                imageDisplay.CssClass = "image2";
            }
            else if (filterListFinal.SelectedValue == "3")
            {
                imageDisplay.CssClass = "image3";
            }
            else if (filterListFinal.SelectedValue == "4")
            {
                imageDisplay.CssClass = "image4";
            }
            else if (filterListFinal.SelectedValue == "5")
            {
                imageDisplay.CssClass = "image5";
            }
            else if (filterListFinal.SelectedValue == "6")
            {
                imageDisplay.CssClass = "image6";
            }
            else if (filterListFinal.SelectedValue == "7")
            {
                imageDisplay.CssClass = "image7";
            }
            else if (filterListFinal.SelectedValue == "8")
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
            if (sizeListFinal.SelectedValue == "1")
            {
                imageDisplay.Width = 400;
                imageDisplay.Height = 200;
            }
            else if (sizeListFinal.SelectedValue == "2")
            {
                imageDisplay.Width = 400;
                imageDisplay.Height = 750;
            }
            else if (sizeListFinal.SelectedValue == "3")
            {
                imageDisplay.Width = 600;
                imageDisplay.Height = 400;
            }
            else if (sizeListFinal.SelectedValue == "4")
            {
                imageDisplay.Height = 800;
                imageDisplay.Width = 600;
            }
            else
            {
                imageDisplay.Height = 500;
                imageDisplay.Width = 800;
            }


        }//end sizelist selected index changed



    } //end class
}//end Namespace