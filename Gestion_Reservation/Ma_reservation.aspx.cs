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
    public partial class Ma_reservation : System.Web.UI.Page
    {
        public static string connection = "Data Source=MARSHALDTEACH;Initial Catalog=Avion_Reservation;Integrated Security=True";
        SqlConnection cn = new SqlConnection(connection);
        public DataTable dt = new DataTable();
        public string id;

        public void remplir_grille()
        {
            string req = "select  Reservation_ID , Client_Name , Com_Name, Source_Loc,Destination_Loc ,Nbr_Place,Date_Reservation , Depart_Time, PHT,Total_PHT,Status_Reservation from Reservation ,Client where   ClientID=" + Declaration.id_client;
            
            SqlCommand cmd = new SqlCommand(req, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                cn.Open();
                remplir_grille();
                cn.Close();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             id = GridView1.SelectedRow.Cells[1].Text;
            
            try
            {
                cn.Open();

                string req = string.Format("select count(*) from Reservation where  Reservation_ID ={0} and Status_Reservation='Reservée'", id);
                SqlCommand cmd = new SqlCommand(req, cn);
                int cpt = (int)cmd.ExecuteScalar();
                if (cpt > 0)
                {
                    /*Ici on doit savoir la difference entre la premier date de reservation et la date d'aujourdui et selon le nombre  de jour on fait dimunuer le rembourssement*/
                    DateTime Date_aujourdhui = DateTime.Now;
                    dt = Reservation_Info();
                    DateTime Date_reservation1 = DateTime.Parse(dt.Rows[0][9].ToString());
                    DateTime Date_reservation = DateTime.Parse(Date_reservation1.ToString("yyyy - MM - dd"));
                     
                    /*La difference doit etre en jours (days)*/
                    TimeSpan dif = Date_aujourdhui - Date_reservation;
                    /*Recuperer le montant de reservation*/
                    double Montant_annuler = float.Parse(dt.Rows[0][12].ToString());

                    if (dif.Days >= 10)
                    {
                        Montant_annuler = Montant_annuler - (Montant_annuler * 0.1);
                    }
                    else
                        if (dif.Days > 5 && dif.Days < 10)
                    {
                        Montant_annuler = Montant_annuler - (Montant_annuler * 0.2);
                    }
                    else
                        if (dif.Days > 5 && dif.Days < 10)
                    {
                        Montant_annuler = Montant_annuler - (Montant_annuler * 0.5);
                    }
                    /*Rembourssement du client*/
                    Montant_annuler = Math.Round(Montant_annuler);

                    string req_client = "Update Client set  Portfeille =  Portfeille +" + Montant_annuler + " where ClientID= " + Declaration.id_client;
                    SqlCommand cmd2 = new SqlCommand(req_client, cn);
                    cmd2.ExecuteNonQuery();
                    /*Le status de la reservation doit etre annulée*/
                    string req_res = "Update Reservation set  Status_Reservation =  'Annuler'  where  Reservation_ID =" + id;

                    SqlCommand cmd3 = new SqlCommand(req_res, cn);
                    cmd3.ExecuteNonQuery();
                    /*Le nombre de place doit etre mit a jour*/
                    int nbr_place = int.Parse(dt.Rows[0][8].ToString());
                    string req_vol = "update Vol set Siege_disponible = Siege_disponible +" + nbr_place + " where Vol_ID ='" + dt.Rows[0][4].ToString() + "'";
                    SqlCommand cmd4 = new SqlCommand(req_vol, cn);
                    cmd4.ExecuteNonQuery();
                    Label1.ForeColor = Color.Purple;
                    Label1.Text = "Reservation Annuler";
                     

                }
                else
                {
                    Label1.ForeColor = Color.Purple;
                    Label1.Text = "Reservation inexistante";
                     
                }
                remplir_grille();
                cn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
        public DataTable Reservation_Info()
        {
            DataTable dt_return = new DataTable();

            string req = "select * from Reservation where Reservation_ID =" + id;
            SqlCommand cmd = new SqlCommand(req, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            dt_return.Load(dr);
            return dt_return;

        }
    }
}