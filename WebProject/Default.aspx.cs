using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject
{
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=E:\Year 3\Web Programming 3\WebProject\WebProject\App_Data\aspnet - WebProject - 20161018111647.mdf;Initial Catalog=aspnet-WebProject-20161018111647;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "Select * from Product";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);

            //da.Fill(dt);
            //con.Close();

            List<string> namesList = new List<string>();

            List<string> stringList = new List<string>();
            string des = "";

            try
            {

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Product", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                des = reader[0].ToString();

                                string colVal = reader["Price"].ToString();
                                string nmeVal = reader["ProductName"].ToString();

                                stringList.Add(colVal);
                                namesList.Add(nmeVal);
                            }
                        }
                    }
                }

                
                lblH3Img1.Text = namesList[0].ToString();
                lblH3Img2.Text = namesList[1].ToString();
                lblH3Img3.Text = namesList[2].ToString();
                lblH3Img4.Text = namesList[3].ToString();
                lblH3Img5.Text = namesList[4].ToString();
                lblH3Img6.Text = namesList[5].ToString();
                lblH3Img7.Text = namesList[6].ToString();
                lblH3Img8.Text = namesList[7].ToString();
                lblH3Img9.Text = namesList[8].ToString();
                lblH3Img10.Text = namesList[9].ToString();
                lblH3Img11.Text = namesList[10].ToString();
                lblH3Img12.Text = namesList[11].ToString();

                //Details
                lblParaImg1.Text = stringList[0].ToString();
                lblParaImg2.Text = stringList[1].ToString();
                lblParaImg3.Text = stringList[2].ToString();
                lblParaImg4.Text = stringList[3].ToString();
                lblParaImg5.Text = stringList[4].ToString();
                lblParaImg6.Text = stringList[5].ToString();
                lblParaImg7.Text = stringList[6].ToString();
                lblParaImg8.Text = stringList[7].ToString();
                lblParaImg9.Text = stringList[8].ToString();
                lblParaImg10.Text = stringList[9].ToString();
                lblParaImg11.Text = stringList[10].ToString();
                lblParaImg12.Text = stringList[11].ToString();
            }
            catch (Exception ex)
            {
                //error handling...
                Response.Write("Error" + ex.Message);


            }
    }

}
    public class ThumbNail
    {
        public byte[] thumb { get; set; }
        public string ProductID { get; set; }
        public ThumbNail()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}