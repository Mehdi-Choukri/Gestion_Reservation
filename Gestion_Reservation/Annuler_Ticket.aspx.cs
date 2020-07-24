﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_Reservation
{
    public partial class Annuler_Ticket : System.Web.UI.Page
    {
        public static string connection = "Data Source=MARSHALDTEACH;Initial Catalog=Avion_Reservation;Integrated Security=True";
        SqlConnection cn = new SqlConnection(connection);
       public DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                
         
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                
                string req =string.Format("select count(*) from Reservation where  Reservation_ID ={0} and Status_Reservation='Reservée'",txt_id.Text);
                SqlCommand cmd = new SqlCommand(req, cn);
                int cpt = (int) cmd.ExecuteScalar();
                if(cpt>0)
                {
                    /*Ici on doit savoir la difference entre la premier date de reservation et la date d'aujourdui et selon le nombre  de jour on fait dimunuer le rembourssement*/
                    DateTime Date_aujourdhui = DateTime.Now;
                    dt = Reservation_Info();
                    DateTime Date_reservation1 = DateTime.Parse(dt.Rows[0][9].ToString());
                    DateTime Date_reservation =DateTime.Parse( Date_reservation1.ToString("yyyy - MM - dd"));
                    
                    /*La difference doit etre en jours (days)*/
                    TimeSpan dif = Date_aujourdhui - Date_reservation;
                    /*Recuperer le montant de reservation*/
                    double Montant_annuler = float.Parse(dt.Rows[0][12].ToString());

                    if(dif.Days>=10)
                    {
                        Montant_annuler=Montant_annuler-(Montant_annuler*0.1);
                    }
                    else
                        if(dif.Days>5 && dif.Days<10)
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
                    
                    string req_client = "Update Client set  Portfeille =  Portfeille +"+ Montant_annuler + " where ClientID= "+Declaration.id_client;
                    SqlCommand cmd2 = new SqlCommand(req_client, cn);
                    cmd2.ExecuteNonQuery();
                    /*Le status de la reservation doit etre annulée*/
                    string req_res = "Update Reservation set  Status_Reservation =  'Annuler'  where  Reservation_ID =" + txt_id.Text;

                    SqlCommand cmd3 = new SqlCommand(req_res, cn);
                    cmd3.ExecuteNonQuery();
                    /*Le nombre de place doit etre mit a jour*/
                    int nbr_place = int.Parse(dt.Rows[0][8].ToString());
                    string req_vol = "update Vol set Siege_disponible = Siege_disponible +" + nbr_place + " where Vol_ID ='"+dt.Rows[0][4].ToString()+"'";
                    SqlCommand cmd4 = new SqlCommand(req_vol, cn);
                    cmd4.ExecuteNonQuery();

                    Response.Write("Reservation Annuler");

                }
                else
                {
                    Response.Write("Reservation inexistante");
                }
                cn.Close();
        }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
}
        public DataTable Reservation_Info ()
        {
            DataTable dt_return = new DataTable();

            string req = "select * from Reservation where Reservation_ID =" + txt_id.Text;
            SqlCommand cmd = new SqlCommand(req, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            dt_return.Load(dr);
            return dt_return;
 
        }
    }
}