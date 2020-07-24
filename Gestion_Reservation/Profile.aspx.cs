using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_Reservation
{
    public partial class Profile : System.Web.UI.Page
    {
        public static string connection = "Data Source=MARSHALDTEACH;Initial Catalog=Avion_Reservation;Integrated Security=True";

        SqlConnection cn = new SqlConnection(connection);
        public void Charge()
        {
            
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Mâle");
            DropDownList1.Items.Add("Femelle");
            cn.Open();
            string req = "select * from Client where C_User='" + Session["user"] + "'";
            SqlCommand cmd = new SqlCommand(req, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            txt_id.Text = dt.Rows[0][0].ToString();
            txt_nc.Text = dt.Rows[0][1].ToString();
            txt_email.Text = dt.Rows[0][3].ToString();
            txt_DN.Text = dt.Rows[0][5].ToString();
            txt_adresse.Text = dt.Rows[0][6].ToString();
            txt_tel.Text = "0" + dt.Rows[0][7].ToString();
            DropDownList1.Text = dt.Rows[0][8].ToString();
            txt_cin.Text = dt.Rows[0][9].ToString();
            Label9.Text = dt.Rows[0][11].ToString();
            cn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!Page.IsPostBack)
            {
                txt_id.ReadOnly = true;
                txt_DN.ReadOnly = true;

                Charge();
            }

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Charge();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
          try
            {
                cn.Open();
                string req = "Update Client set C_Nom='" + txt_nc.Text + "',C_Mail='" + txt_email.Text + "',C_Address='" + txt_adresse.Text + "',C_Phone=" + txt_tel.Text + ",C_Sexe='" + DropDownList1.Text + "',C_CIN='" + txt_cin.Text + "' where C_User='" + Session["user"] + "'";
                SqlCommand cmd = new SqlCommand(req, cn);

                int i = cmd.ExecuteNonQuery();


                Response.Write("<script>alert('Modification faite avec succee')</script>");


                Response.Write(1.ToString());
                cn.Close();
            }
            catch
            (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }



        }
    }
}