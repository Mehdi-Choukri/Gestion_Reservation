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
    public partial class Form_Recherche : System.Web.UI.Page
    {
        public static string connection = "Data Source=MARSHALDTEACH;Initial Catalog=Avion_Reservation;Integrated Security=True";

        SqlConnection cn = new SqlConnection(connection);
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"]==null)
            {
                Response.Redirect("Authentification.aspx");
            }
            if(!Page.IsPostBack)
            {
                string req = "select Ville_nom from Villes";
                cn.Open();
                SqlCommand cmd = new SqlCommand(req, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                drop_villeA.Items.Clear();
                drop_villeD.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    drop_villeA.Items.Add(dt.Rows[i][0].ToString());
                    drop_villeD.Items.Add(dt.Rows[i][0].ToString());
                }
                nbr_siege.Items.Clear();
                for (int i = 1; i < 11; i++)
                {
                    nbr_siege.Items.Add(i.ToString());
                }
                //Heure_dep.Items.Clear();
                //for (int i = 0; i < 3; i++)
                //{
                //    for (int j = 0; j < 10; j++)
                //    {
                //        if(i==2 && j==4)
                //        {
                //            break;
                //        }
                //        Heure_dep.Items.Add(i.ToString() + j.ToString() + ":00");
                //    }

                //}


                //string req_grid = "select V.Vol_ID,C.Com_Name,loc1.Depart_ville,V.Depart_Time,loc2.Arrive_ville,V.Arrival_Time,V.PrixHT from Vol V join Compagnie C on C.Com_ID = V.Compagnie_ID join Location_Villes loc1 on loc1.id = V.DepartLoc_ID join Location_Villes loc2 on loc2.id = V.ArriveLoc_ID";
                //SqlCommand cmd_grid = new SqlCommand(req_grid, cn);
                //SqlDataReader dr_grid = cmd_grid.ExecuteReader();
                //DataTable dt_vol = new DataTable();
                //dt_vol.Load(dr_grid);
                //GridView1.DataSource = dt_vol;
                //GridView1.DataBind();
                
                cn.Close();

            }
        }

        //public void recherche_grid ()

        //{
            
        //    try
        //    {
        //        SqlParameter sp1 = new SqlParameter();
        //        SqlParameter sp2 = new SqlParameter();
        //        SqlParameter sp3 = new SqlParameter();
        //        SqlParameter sp4 = new SqlParameter();
        //        SqlParameter sp5 = new SqlParameter();
        //        SqlCommand cmd = new SqlCommand("Recherche_Vol_SP ", cn);
        //        cmd.Parameters.Add("@P_ville_depart", SqlDbType.VarChar, 50).Value = drop_villeD.Text;
        //        cmd.Parameters.Add("@P_ville_Arriver", SqlDbType.VarChar, 50).Value = drop_villeA.Text;
        //        cmd.Parameters.Add("@p_Date_depart", SqlDbType.VarChar, 50).Value = txt_date.ToString();
        //        cmd.Parameters.Add("@p_Heure_depart", SqlDbType.VarChar,50).Value = Heure_dep.Text;
        //        cmd.Parameters.Add("@P_Siege", SqlDbType.Int).Value = nbr_siege.Text;
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        DataTable dt = new DataTable();
        //        dt.Load(cmd.ExecuteReader());
        //        GridView1.DataSource = dt;
        //        GridView1.DataBind();
        //    }
        //    catch(Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //    }


        //}

        protected void Button10_Click(object sender, EventArgs e)
        {
            /*Le traitement se fait par le biais d'un datasource configuré avec la controle bouton */
            //cn.Open();
            //recherche_grid();
            //cn.Close();
            //GridView1.DataSource = SqlDataSource1;
            //GridView1.DataBind();
            Declaration.nbr_place_reservé = int.Parse(nbr_siege.Text);
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

            int indice = e.NewSelectedIndex;
            Declaration.id_vol = GridView1.Rows[indice].Cells[1].Text;
            string id = GridView1.Rows[indice].Cells[1].Text;
             
            Response.Redirect("Reserver.aspx?ID_VOL="+id);
          



        }
    }
}