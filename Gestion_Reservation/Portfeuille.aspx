<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Portfeuille.aspx.cs" Inherits="Gestion_Reservation.Portfeuille" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            width: 80px;
            height: 60px;
         

        }
        .auto-style8 {
            width: 75px;
        }
        h3{
            text-align:center;
            color:#0094ff;
        }
          .BTNPORTFEUILLE
      {
          background-color:cornflowerblue;
          color:white;
          font-size:10px;
          border-radius:5px;
  font-weight:bold;
 
 
      }
        .BTNPORTFEUILLE:hover{
  background:#ff0000;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr >
            <td rowspan="5" class="auto-style8" >
                <img alt="" class="auto-style7" src="Icons/PayPalCard.png" /></td>
            <td class="auto-style2" colspan="2">
             <h3>PayPal :</h3>   
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Utilisateur :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Votre Balance :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Voulez vous Changer votre balance ?"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_balance" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button class="BTNPORTFEUILLE" ID="Button10" runat="server" Text="Modifier" OnClick="Button10_Click" />
            </td>
            <td>
                <asp:Label ID="Label7" runat="server" ForeColor="#009933"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
