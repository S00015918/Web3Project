using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject_PostersWorking
{
    public partial class Admin_AddItemsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                //ddlImages.DataSource = GetData("SELECT EmpID, Name FROM Content");
               
                //ddlImages.DataTextField = "Name";

                //ddlImages.DataValueField = "EmpID";
                //ddlImages.DataBind();

            }
        }

        private DataTable GetData(string query)
        {DataTable dt = new DataTable();
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(dt);
                    }
                }
                return dt;
            }
        }
        protected void FetchImage(object sender, EventArgs e)
        {
            string id = ddlImages.SelectedItem.Value;
            posterImage.Visible = id != "0";
            if (id != "0")
            {
                byte[] bytes = (byte[])GetData("SELECT ImageFile FROM Product WHERE ProductID =" + id).Rows[0]["ImageFile"];
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                posterImage.ImageUrl = "data:image/png;base64," + base64String;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This is the insert method 
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=E:\Year3\WebProgramming3\WebProject\WebProject\App_Data\aspnet-WebProject-20161018111647.mdf;InitialCatalog=aspnet-WebProject-20161018111647;IntegratedSecurity=True"))
                {
                    SqlCommand cmd = new SqlCommand("insert into Product values(@ProductID,@ProductName,@Quantity,@Price,@Image, @Genre)", con);
                    cmd.Parameters.AddWithValue("@ProductID", PosterID.Text);
                    cmd.Parameters.AddWithValue("@ProductName", Postername.Text);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                    cmd.Parameters.AddWithValue("@Genre", Genre.Text);



                    int img = ImageUpload.PostedFile.ContentLength;

                    byte[] msdata = new byte[img];

                    ImageUpload.PostedFile.InputStream.Read(msdata, 0, img);

                    cmd.Parameters.AddWithValue("@image", msdata);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();//Here I must include error checking.

                    con.Close();

                    //FillDropDown();
                    Response.Write("Error");
                    PosterID.Text = "";
                    Postername.Text = "";
                    Quantity.Text = "";
                    Genre.Text = "";
                }
            }
            catch
            {
                //Here I styled the Responce to show at the eye level of the user.
                Response.Write("This ID already exists please use a new ID otherwise pick the update option!");
            }
            finally
            {
                //The Server.GetLastError() is to display any other errors even when using the finally catch block.
                Response.Write("Error" + Server.GetLastError());
            }

        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MyItemsDatabase.mdf;Integrated Security=True"))
                {


                    SqlCommand cmd = new SqlCommand("update Product set ProductID = @id, ProductName = @name, QuantityInStock = @Quantity, Genre = @genre, ImageFile = @image where @id = ProductID", con);

                    cmd.Parameters.AddWithValue("@id", PosterID.Text);
                    cmd.Parameters.AddWithValue("@name", Postername.Text);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity.Text);
                    cmd.Parameters.AddWithValue("@genre", Genre.Text);


                    int img = ImageUpload.PostedFile.ContentLength;

                    byte[] msdata = new byte[img];

                    ImageUpload.PostedFile.InputStream.Read(msdata, 0, img);

                    cmd.Parameters.AddWithValue("@image", msdata);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();

                    con.Close();

                    Response.Write("");
                    PosterID.Text = "";
                    Postername.Text = "";
                    Quantity.Text = "";
                    Genre.Text = "";

                }
            }
            catch (Exception ex)
            {
                Response.Write("Error" + ex.Message);
            }

        }
    }
}