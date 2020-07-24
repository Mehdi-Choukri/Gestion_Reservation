using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
namespace Gestion_Reservation
{
    public partial class Reserver : System.Web.UI.Page
    {
        public static string connection = "Data Source=MARSHALDTEACH;Initial Catalog=Avion_Reservation;Integrated Security=True";

        SqlConnection cn = new SqlConnection(connection);
       public static float Montant_final;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Authentification.aspx");
            }
            if (!Page.IsPostBack)
            {
                cn.Open();
                string req = "select V.Vol_ID, C.Com_Name,V.Depart_Date,loc1.Depart_ville,V.Depart_Time,loc2.Arrive_ville,V.Arrival_Time,V.PrixHT  from Vol V join Compagnie C on C.Com_ID=V.Compagnie_ID join Location_Villes loc1 on loc1.id= V.DepartLoc_ID join Location_Villes loc2 on loc2.id=V.ArriveLoc_ID where V.Vol_ID='" + Request.QueryString["ID_VOL"] + "'";
                SqlCommand cmd = new SqlCommand(req, cn);
                 

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                L_user.Text = Session["user"].ToString();
                l_nvol.Text = dt.Rows[0][0].ToString();
                l_compagnie.Text = dt.Rows[0][1].ToString();
                L_Datevoyage.Text = dt.Rows[0][2].ToString().Substring(0, 10);
                l_villedepart.Text = dt.Rows[0][3].ToString();
                L_heure.Text = dt.Rows[0][4].ToString();
                L_villeArriver.Text = dt.Rows[0][5].ToString();
                L_datereservation.Text = DateTime.Now.ToShortDateString();
                L_nbr_siege.Text = Declaration.nbr_place_reservé.ToString();

                l_frais.Text = dt.Rows[0][7].ToString();
                Montant_final = Declaration.nbr_place_reservé * float.Parse(dt.Rows[0][7].ToString());
                cn.Close();
                 
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            //DateTime date_ajourdhui= DateTime.Now;


            //  try
            //{
            //    cn.Open();
            //    SqlCommand cmd = new SqlCommand("Confirm_Reservation_SP", cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@Client_ID", SqlDbType.Int).Value = Declaration.id_client;
            //    cmd.Parameters.AddWithValue("@Client_Name", SqlDbType.VarChar).Value = Declaration.nom_client;
            //    cmd.Parameters.AddWithValue("@Date_Aujourdhui", SqlDbType.Date).Value = "06-02-2019";
            //    cmd.Parameters.AddWithValue("@Vol_ID", SqlDbType.VarChar).Value = l_nvol.Text;
            //    cmd.Parameters.AddWithValue("@Com_Name", SqlDbType.VarChar).Value = l_compagnie.Text;
            //    cmd.Parameters.AddWithValue("@Source_Loc", SqlDbType.VarChar).Value = l_villedepart.Text;

            //    cmd.Parameters.AddWithValue("@Destination_Loc", SqlDbType.VarChar).Value = L_villeArriver.Text;
            //    cmd.Parameters.AddWithValue("@Nbr_Place", SqlDbType.Int).Value = L_nbr_siege.Text;
            //    cmd.Parameters.AddWithValue("@Date_Reservation", SqlDbType.Date).Value = "06-08-2019";
            //    cmd.Parameters.AddWithValue("@Depart_Time", SqlDbType.Time).Value = L_Datevoyage.Text;
            //    cmd.Parameters.AddWithValue("@PHT", SqlDbType.Float).Value = l_frais.Text;

            //    cmd.Parameters.AddWithValue("@Status_Reservation", SqlDbType.VarChar);
            //    cmd.Parameters.AddWithValue("@Status_R", SqlDbType.Int).Direction = ParameterDirection.Output;
            //    cmd.ExecuteNonQuery();
            //    if (cmd.Parameters["@Status_R"].Value.ToString() == "-1")
            //    {
            //        Response.Write("<script>alert('Le montant de votre port feuille est inferieur aux frais')</script>");
            //    }
            //    else
            //    {
            //        Response.Write("Reservation faite avec succee");

            //    }
            //    cn.Close();
            //}                
            //   catch (Exception ex)
            //{
            //    Response.Write(ex.Message);
            //}
            try
            {
                cn.Open();
                string req = "select Portfeille from Client where ClientID= " + Declaration.id_client;
                SqlCommand cmd = new SqlCommand(req, cn);

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                float montant = float.Parse(dt.Rows[0][0].ToString());
                if (montant > Montant_final)
                {


                    DateTime date_ajourdhui = DateTime.Now;
                    DateTime date_voyage = DateTime.Parse( L_datereservation.Text);
                    string req2 = string.Format("insert into Reservation  values (  {0} ,'{1}','{2}' ,'{3}' ,'{4}','{5}','{6}' , {7},'{8}' ,'{9}' ,{10} ,{11},'{12}')", Declaration.id_client, Declaration.nom_client, date_ajourdhui.ToString("yyyy - MM - dd"), l_nvol.Text, l_compagnie.Text, L_villeArriver.Text, l_villedepart.Text, L_nbr_siege.Text, date_voyage.ToString("yyyy - MM - dd"), L_heure.Text.Substring(0, 5), l_frais.Text, Montant_final, "Reservée");
                    SqlCommand cmd2 = new SqlCommand(req2, cn);
                    int i = cmd2.ExecuteNonQuery();
                    if (i == 1)
                    {
                        string req3 = "update Client  set  Portfeille =  Portfeille - " + Montant_final + " where ClientID=" + Declaration.id_client;
                        SqlCommand cmd3 = new SqlCommand(req3, cn);
                        cmd3.ExecuteNonQuery();

                        string req4 = "update Vol set Siege_disponible  = Siege_disponible-" + L_nbr_siege.Text + "where Vol_ID = '" + l_nvol.Text + "'";
                        SqlCommand cmd4 = new SqlCommand(req4, cn);
                        cmd4.ExecuteNonQuery();

                        Lb_message.ForeColor = Color.Blue;
                        Lb_message.Text = "Reservation faite avec succee";
                  
                        

                    }
                }
                else
                {
                     
                    Lb_message.ForeColor = Color.Red;
                    Lb_message.Text = "Echec de Reservation veuillez consulté votre porte feuille ";

                }
        }catch (Exception ex)
            {
                Response.Write(ex.Message);
            }






}
    }
}