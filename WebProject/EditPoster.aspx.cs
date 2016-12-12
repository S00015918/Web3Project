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

        protected void btnUploadImage_Clicked(object sender, EventArgs e)
        {



            //byte[] imageArray1 = System.IO.File.ReadAllBytes(Server.MapPath("Images//" + posterUpload.FileName));

            //Bitmap bmpPostedImage = new Bitmap(posterUpload.PostedFile.InputStream);

            //byte[] byteArrayStoredImage = imageArray1;
            //MemoryStream imgStream = new MemoryStream(byteArrayStoredImage);
            //System.Drawing.Bitmap bmpStoredImage = new Bitmap(imgStream);



            //check to see if posterupload has a file. If it does, it executes the following code.
            if (posterUpload.HasFile)
            {

                posterUpload.SaveAs(Server.MapPath("Images//" + posterUpload.FileName)); //saves the uploaded file to the images folder

                //puts the path into a variable, this is used to check to make sure that there isn't already a file of the same name in that folder.
                string ImageSavePath = Server.MapPath("Images//"); //Temporary until database is implemented!
                string fileName = posterUpload.FileName;
                string imgPathToCheck = ImageSavePath + fileName;
                string temporaryFileName = "";


                //if file already exists, add the counter variable to start of the name and save.
                if (System.IO.File.Exists(imgPathToCheck))
                {
                    int counter = 2;

                    while (System.IO.File.Exists(imgPathToCheck))
                    {
                        temporaryFileName = counter.ToString() + fileName;
                        imgPathToCheck = ImageSavePath + temporaryFileName;
                        counter++;
                    }//end while

                    fileName = temporaryFileName;


                    outputLabel.Text = string.Format("Image uploaded as {0}!", fileName);  //populates the label with text and disables the upload button.
                    outputLabel.CssClass = "alert alert-success";
                    btnUploadImage.CssClass = "btn btn-primary disabled";

                }//end if
                else
                {
                    //if file doesn't exist, image is saved as normal.
                    outputLabel.Text = "Image uploaded!";
                    outputLabel.CssClass = "alert alert-success";
                    btnUploadImage.CssClass = "btn btn-primary disabled";
                }//end else

                ImageSavePath += fileName;

                posterUpload.SaveAs(ImageSavePath);
                //Displays the uploaded image.
                imageDisplay.ImageUrl = "Images/" + fileName;


            }//end if
            else
            {
                //if an image isn't selected it will output this text
                outputLabel.Text = "You must select an image!";
                outputLabel.CssClass = "alert alert-danger";
            }//end else


        }//end btnuploadclicked



        //public Bitmap toGrayscale(Bitmap bmpOriginal)
        //{
        //    int width, height;
        //    height = bmpOriginal.getHeight();
        //    width = bmpOriginal.getWidth();

        //    Bitmap bmpGrayscale = Bitmap.createBitmap(width, height, Bitmap.Config.ARGB_8888);
        //    Canvas c = new Canvas(bmpGrayscale);
        //    Paint paint = new Paint();
        //    ColorMatrix cm = new ColorMatrix();
        //    cm.setSaturation(0);
        //    ColorMatrixColorFilter f = new ColorMatrixColorFilter(cm);
        //    paint.setColorFilter(f);
        //    c.drawBitmap(bmpOriginal, 0, 0, paint);
        //    return bmpGrayscale;
        //}




        protected void btnApplyChanges_Click(object sender, EventArgs e)
        {
            sizeListFinal_SelectedIndexChanged(sender, e);
            borderList_SelectedIndexChanged(sender, e);
            filterListFinal_SelectedIndexChanged(sender, e);

        }//end btnapply

        protected void filterListFinal_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selected = Convert.ToInt32(filterList.SelectedValue);

            while (selected > 0 && selected < 9)
            {

                imageDisplay.CssClass = string.Format("image{0}", selected);
                break;
            }

            //if (filterList.SelectedValue == "1")
            //{
            //    imageDisplay.CssClass = "image1";
            //}
            //else if (filterList.SelectedValue == "2")
            //{
            //    imageDisplay.CssClass = "image2";
            //}
            //else if (filterList.SelectedValue == "3")
            //{
            //    imageDisplay.CssClass = "image3";
            //}
            //else if (filterList.SelectedValue == "4")
            //{
            //    imageDisplay.CssClass = "image4";
            //}
            //else if (filterList.SelectedValue == "5")
            //{
            //    imageDisplay.CssClass = "image5";
            //}
            //else if (filterList.SelectedValue == "6")
            //{
            //    imageDisplay.CssClass = "image6";
            //}
            //else if (filterList.SelectedValue == "7")
            //{
            //    imageDisplay.CssClass = "image7";
            //}
            //else if (filterList.SelectedValue == "8")
            //{
            //    imageDisplay.CssClass = "image8";
            //}
            //else if (filterList.SelectedValue == "9")
            //{
            //    imageDisplay.CssClass = "img-responsive";
            //}
            //else
            //{
            //    // imageDisplay.CssClass = "";
            //}


        }//end filterlistfinal_selectedindexchanged

        protected void sizeListFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = Convert.ToInt32(sizeList.SelectedValue);

            int selectedWidth = 800;
            int selectedHeight = 500;

            while (selected > 0 && selected < 5)
            {
                if (sizeList.SelectedValue == "1")
                {
                    selectedWidth = 400;
                    selectedHeight = 200;
                }
                else if (sizeList.SelectedValue == "2")
                {
                    selectedHeight = 800;
                    selectedWidth = 600;
                }
                else if (sizeList.SelectedValue == "3")
                {
                    selectedWidth = 600;
                    selectedHeight = 400;
                }
                else if (sizeList.SelectedValue == "4")
                {
                    selectedHeight = 600;
                    selectedWidth = 800;
                }
                else
                {
                    selectedHeight = 500;
                    selectedWidth = 800;
                }
                lblSize.Text = string.Format("Your poster will be {0} x {1}!", selectedHeight, selectedWidth);

                break;


            }//end while






        }//end sizelist selected index changed

        protected void borderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = Convert.ToInt32(borderList.SelectedValue);

            while (selected > 1 && selected < 5)
            {

                if (borderList.SelectedValue == "2")
                {
                    imageDisplay.CssClass = "img-circle img-responsive";
                }
                else if (borderList.SelectedValue == "3")
                {
                    imageDisplay.CssClass = "img-thumbnail img-responsive";
                }
                else if (borderList.SelectedValue == "4")
                {
                    imageDisplay.CssClass = "img-rounded img-responsive";
                }
                else
                {
                    // imageDisplay.CssClass = "img-responsive";
                }
                break;
            }//end while


        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart.aspx");
        }
    } //end class
}//end Namespace