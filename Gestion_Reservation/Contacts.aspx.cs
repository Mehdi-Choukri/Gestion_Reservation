using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Gestion_Reservation
{
    public partial class Contacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static string connection = "Data Source=MARSHALDTEACH;Initial Catalog=Avion_Reservation;Integrated Security=True";
        SqlConnection cn = new SqlConnection(connection);

        protected void Button11_Click(object sender, EventArgs e)
        {
           try
            {
                cn.Open();
                string req = string.Format("insert into Contact values ('{0}','{1}','{2}')", txt_nom.Text, txt_mail.Text, txt_msg.InnerText);
                SqlCommand cmd = new SqlCommand(req, cn);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    Label1.ForeColor = Color.Green;
                    Label1.Text = "Votre message a ete bien envoyer";
                     
                }
                else
                {
                    Label1.ForeColor = Color.Red;
                    Label1.Text = "Echec d'envoie";
                }
                cn.Close();

            }
            catch
            (Exception ex)
            {
                Response.Write(ex.Message);
            }
         
        }
    }
}