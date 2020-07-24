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
    public partial class Modifier_mdp : System.Web.UI.Page
    {
        public static string connection = "Data Source=MARSHALDTEACH;Initial Catalog=Avion_Reservation;Integrated Security=True";

        SqlConnection cn = new SqlConnection(connection);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                string req = "select  C_Pass from Client where C_User='" + Session["user"] + "'";
                cn.Open();
                SqlCommand cmd = new SqlCommand(req, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                string Ancien_pw = dt.Rows[0][0].ToString();
                if(!txt_ap.Text.Equals(Ancien_pw))
                {
                    Label4.Text = "Votre Ancienne Mots de passe est incorrect";
                }
                else
                    if(!txt_NP.Text.Equals(txt_cp.Text) || txt_NP.Text.Length < 3)
                {
                    Label6.Text = "La confirmation du mots de passe est incorrect ";
                    Label4.Text = "";
                   
                        Label8.Text = " trop court 3 characteres au minimun";
                    
                }
                else
                {
                    Label8.Text = "";
                    Label6.Text = "";
                    string req2 = "update Client set C_Pass='" + txt_cp.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(req2, cn);
                    cmd2.ExecuteNonQuery();
                    Label7.Text = "Modification faite avec succee";

                }
                cn.Close();
            }
            catch
            (Exception ex )
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }

        }
    }
}