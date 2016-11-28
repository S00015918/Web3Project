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
    public partial class UploadPoster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnUploadImage_Clicked(object sender, EventArgs e)
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
                    btnUploadImage.CssClass = "btn btn-primary disabled";

                }//end if
                else
                {
                    outputLabel.Text = "Image uploaded!";
                    outputLabel.CssClass = "alert alert-success";
                    btnUploadImage.CssClass = "btn btn-primary disabled";
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


        }

        protected void btnEditPoster_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditPoster.aspx");
        }
    }
}