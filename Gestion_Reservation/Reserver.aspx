<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Reserver.aspx.cs" Inherits="Gestion_Reservation.Reserver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            width: 232px;
        }
        .auto-style8 {
            width: 194px;
            
        }
        .auto-style9 {
            width: 232px;
            height: 23px;
        }
        .auto-style10 {
            width: 194px;
            height: 23px;
        }
        .BTNR
      {
          background-color:cornflowerblue;
          color:white;
          font-size:12px;
          border-radius:3px;
  font-weight:bold;
 
 
      }
         .BTNR:hover{
  background:#ff0000;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label1" runat="server" Text="User"></asp:Label>
            </td>
            <td class="auto-style8">:<asp:Label ID="L_user" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label2" runat="server" Text="N° de Vol"></asp:Label>
            </td>
            <td class="auto-style8">:<asp:Label ID="l_nvol" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label3" runat="server" Text="Compagnie Aerienne"></asp:Label>
            </td>
            <td class="auto-style8">:<asp:Label ID="l_compagnie" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;<asp:Label ID="Label4" runat="server" Text="Ville de depart"></asp:Label>
            </td>
            <td class="auto-style8">:<asp:Label ID="l_villedepart" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label5" runat="server" Text="Ville d'arriver"></asp:Label>
            </td>
            <td class="auto-style8">:<asp:Label ID="L_villeArriver" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label6" runat="server" Text="Date du voyage"></asp:Label>
            </td>
            <td class="auto-style8">:<asp:Label ID="L_Datevoyage" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="Label7" runat="server" Text="Heure du voyage"></asp:Label>
            </td>
            <td class="auto-style10">:<asp:Label ID="L_heure" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label8" runat="server" Text="Date de reservation"></asp:Label>
            </td>
            <td class="auto-style8">:<asp:Label ID="L_datereservation" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label9" runat="server" Text="Nombre de sieges reservées"></asp:Label>
            </td>
            <td class="auto-style8">:<asp:Label ID="L_nbr_siege" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label10" runat="server" Text="Frais"></asp:Label>
            </td>
            <td class="auto-style8">:<asp:Label ID="l_frais" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Button ID="Button10" runat="server" CssClass="BTNR" Text="Annuler" />
            </td>
            <td class="auto-style8">
                <asp:Button ID="Button11" runat="server" CLASS="BTNR" Text="Continuer la reservation" OnClick="Button11_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">
                <asp:Label ID="Lb_message" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
