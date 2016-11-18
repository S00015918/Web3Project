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
                string savePath = "E:/College/ThirdYear/Web Programming/WebProject/Web3Project-master/WebProject/Images/";
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

                    outputLabel.Text = "Image uploaded!";

                }//end if
                else
                {
                    outputLabel.Text = "Image uploaded!";
                }//end else

                savePath += fileName;

                posterUpload.SaveAs(savePath);
                imageDisplay.ImageUrl = "Images/" + fileName;

            }//end if
            else
            {
                outputLabel.Text = "You must select an image!";
            }//end else

            filterList_SelectedIndexChanged(sender, e);


        }//end uploadImage_Click



        protected void filterList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (filterList.SelectedValue == "1")
            {
                // imageDisplay.
            }
            else if (filterList.SelectedValue == "2")
            {

            }
            else if (filterList.SelectedValue == "3")
            {

            }
            else if (filterList.SelectedValue == "4")
            {

            }
            else if (filterList.SelectedValue == "5")
            {

            }

        }//end filterlist_selectedindexchanged

        //private static Bitmap ApplyColorMatrix(Image sourceImage, ColorMatrix colorMatrix)
        //{
        //    Bitmap bmp32BppSource = GetArgbCopy(sourceImage);
        //    Bitmap bmp32BppDest = new Bitmap(bmp32BppSource.Width, bmp32BppSource.Height, PixelFormat.Format32bppArgb);

        //    using (Graphics graphics = Graphics.FromImage(bmp32BppDest))
        //    {
        //        ImageAttributes bmpAttributes = new ImageAttributes();
        //        bmpAttributes.SetColorMatrix(colorMatrix);

        //        graphics.DrawImage(bmp32BppSource, new Rectangle(0, 0, bmp32BppSource.Width, bmp32BppSource.Height),
        //            0, 0, bmp32BppSource.Width, bmp32BppSource.Height, GraphicsUnit.Pixel, bmpAttributes);
        //    }//end using
        //    bmp32BppSource.Dispose();
        //    return bmp32BppDest;

        //}//end applycolormatrix


        //public static Bitmap DrawAsNegative(this System.Drawing.Image sourceImage)
        //{
        //    ColorMatrix colorMatrix = new ColorMatrix(new float[][]
        //    {
        //        new float[] {-1, 0, 0, 0, 0},
        //        new float[] {0, -1, 0, 0 ,0},
        //        new float[] {0, 0, -1, 0, 0},
        //        new float[] {1, 1, 1, 1, 1}
        //    });

        //    return ApplyColorMatrix(sourceImage, colorMatrix);
        //}



    } //end class
}//end Namespace