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
    public partial class Authentification : System.Web.UI.Page
    {
        public static string connection = "Data Source=MARSHALDTEACH;Initial Catalog=Avion_Reservation;Integrated Security=True";

        SqlConnection cn = new SqlConnection(connection);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string req = "select C_User , C_Pass, ClientID,C_Nom from  Client";
            cn.Open();
            SqlCommand cmd = new SqlCommand(req, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            bool trouve = false;
           while (dr.Read())
            {
                if(dr[0].ToString().Equals(txt_login.Text) && dr[1].ToString().Equals(txt_pw.Text))
                {
                    Declaration.id_client = int.Parse(dr[2].ToString());
                    Declaration.nom_client = dr[3].ToString();
                    trouve = true;
                    break;
                }
            }
           if(trouve==true)
            {
                Session["user"] = txt_login.Text;
                
                Response.Redirect("Acceuil.aspx");

            }
            else
            {
                Response.Write("<script>alert('Login ou Mdp Incorrect')</script>");


            }
        }
    }
}