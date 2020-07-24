using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestion_Reservation
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        Declaration D = new Declaration();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Panel2.Visible = false;
            
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Panel1.Visible = !Panel1.Visible;

        }

        protected void ImageButton1_Unload(object sender, EventArgs e)
        {
            
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if(Session["user"]!=null)
            {
                Panel2.Visible = !Panel2.Visible;
                
            }
            else
            {
                Response.Redirect("Authentification.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Acceuil.aspx");
            }
            else
            {
                Response.Redirect("Authentification.aspx");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Profile.aspx");
            }
            else
            {
                Response.Redirect("Authentification.aspx");
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Modifier_mdp.aspx");
            }
            else
            {
                Response.Redirect("Authentification.aspx");
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
           

                 if (Session["user"] != null)
            {
                Response.Redirect("Portfeuille.aspx");
            }
            else
            {
                Response.Redirect("Authentification.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Form_Recherche.aspx");
            }
            else
            {
                Response.Redirect("Authentification.aspx");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Vols.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Write("<script>alert('A bientôt')</script>");
            Response.Redirect("Authentification.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Annuler_Ticket.aspx");
            }
            else
            {
                Response.Redirect("Authentification.aspx");
            }


        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Ma_reservation.aspx");
            }
            else
            {
                Response.Redirect("Authentification.aspx");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contacts.aspx");
        }
    }
}