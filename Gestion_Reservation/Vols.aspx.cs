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
    public partial class Vols : System.Web.UI.Page
    {
        public static string connection = "Data Source=MARSHALDTEACH;Initial Catalog=Avion_Reservation;Integrated Security=True";

        SqlConnection cn = new SqlConnection(connection);

        public void  remplir_grille_condition (double cout)
        {
            string req_grid = "select V.Vol_ID,C.Com_Name,V.Depart_Date,loc1.Depart_ville,V.Depart_Time,loc2.Arrive_ville,V.Arrival_Time,V.PrixHT from Vol V join Compagnie C on C.Com_ID = V.Compagnie_ID join Location_Villes loc1 on loc1.id = V.DepartLoc_ID join Location_Villes loc2 on loc2.id = V.ArriveLoc_ID where V.PrixHT<="+cout;
            SqlCommand cmd_grid = new SqlCommand(req_grid, cn);
            SqlDataReader dr_grid = cmd_grid.ExecuteReader();
            DataTable dt_vol = new DataTable();
            dt_vol.Load(dr_grid);
            GridView1.DataSource = dt_vol;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
              
                cn.Open();
                string req_grid = "select V.Vol_ID,C.Com_Name,V.Depart_Date,loc1.Depart_ville,V.Depart_Time,loc2.Arrive_ville,V.Arrival_Time,V.PrixHT from Vol V join Compagnie C on C.Com_ID = V.Compagnie_ID join Location_Villes loc1 on loc1.id = V.DepartLoc_ID join Location_Villes loc2 on loc2.id = V.ArriveLoc_ID ";
                SqlCommand cmd_grid = new SqlCommand(req_grid, cn);
                SqlDataReader dr_grid = cmd_grid.ExecuteReader();
                DataTable dt_vol = new DataTable();
                dt_vol.Load(dr_grid);
                GridView1.DataSource = dt_vol;
                GridView1.DataBind();
                cn.Close();
            }
        }

        protected void txt_budget_TextChanged(object sender, EventArgs e)
        {
        
            cn.Open();
            remplir_grille_condition(double.Parse(txt_budget.Text));

            cn.Close();
        }
    }
}