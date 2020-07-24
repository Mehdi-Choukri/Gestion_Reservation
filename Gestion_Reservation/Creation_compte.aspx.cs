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
    public partial class Creation_compte : System.Web.UI.Page
    {
        public static string connection = "Data Source=MARSHALDTEACH;Initial Catalog=Avion_Reservation;Integrated Security=True";

        SqlConnection cn = new SqlConnection(connection);
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                Panel p = new Panel();
                p.Visible = false;
                DropDownList1.Items.Clear();
                DropDownList1.Items.Add("Choisissez votre Sexe");
                DropDownList1.Items.Add("Mâle");
                DropDownList1.Items.Add("Femelle");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                string req = "insert into Client values ('" + txt_nom.Text + "','" + txt_user.Text + "','" + txt_mail.Text + "','" + txt_pw.Text + "','" + Calendar1.SelectedDate.ToString("MM/dd/yyyy") + "','" + txt_adresse.Text + "','" + txt_tel.Text + "','" + DropDownList1.Text + "','" + txt_cin.Text + "'," + float.Parse(txt_pf.Text) + ",'" + DateTime.Now.ToString("MM/dd/yyyy") + "')";
               
                cn.Open();
                string gender="";
                if(DropDownList1.Text== "Mâle")
                {
                    gender = "MR";
                }
                else
                {
                    gender = "MMe";
                }
                SqlCommand cmd = new SqlCommand(req, cn);
               int i= cmd.ExecuteNonQuery();
                if (DropDownList1.Text!= "Choisissez votre Sexe" && i==1)
                {
                    
                    Session["user"] = txt_user.Text;

                    Response.Write("<script>alert('Bienvenue "+gender+" : "+txt_user.Text + "')</script>");
                    
                    Response.Redirect("Acceuil.aspx");

                }
                else
                {
                    Response.Write("<script>alert('Veuillez selectionnez votre Sexe')</script>");
                }
                
            }
            catch
            (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            txt_user.Text = "";
            txt_tel.Text = "";
            txt_pw.Text = "";
            txt_pf.Text = "";
            txt_nom.Text = "";
            txt_mail.Text = "";
            txt_cin.Text = "";
            txt_adresse.Text = "";
            DropDownList1.Text = "Choisissez votre Sexe";

        }
    }
}