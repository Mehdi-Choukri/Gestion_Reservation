using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Gestion_Reservation
{
    public partial class Portfeuille : System.Web.UI.Page
    {
        public static string connection = "Data Source=MARSHALDTEACH;Initial Catalog=Avion_Reservation;Integrated Security=True";

        SqlConnection cn = new SqlConnection(connection);
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string req = "select  Portfeille from Client where C_User='" + Session["user"].ToString()+"'";
                cn.Open();
                SqlCommand cmd = new SqlCommand(req, cn);
                Label3.Text = Session["user"].ToString();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                Label5.Text = dt.Rows[0][0].ToString();
                cn.Close();

            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if(int.Parse(txt_balance.Text) <= 20000)
            {
                string req = "Update Client set Portfeille=" + txt_balance.Text + "where C_User = '" + Session["user"].ToString() + "'";
                cn.Open();
                SqlCommand cmd = new SqlCommand(req, cn);
                cmd.ExecuteNonQuery();
                Label7.Text = "Modification faite avec succee";
                cn.Close();
            }
            else
            {
                Label7.Text = "Le Montant doit etre inferieur a 20000 DH ";
            }
                
        }
    }
}