<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Gestion_Reservation.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        h3{
            text-align:center;
            
        }
        .PBTN
      {
          background-color:aqua;
          color:white;
          font-size:8px;
          border-radius:5px;
  font-weight:bold;
  align-items:center;
 
      }
         .PBTN:hover{
  background:#ff0000;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr >
            <td colspan="2"><h3>Profile:</h3></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Id :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_id" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Nom Complet :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_nc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Date de Naissance :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_DN" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Email :</td>
            <td>
                <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Adresse :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_adresse" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Telephone :</td>
            <td>
                <asp:TextBox ID="txt_tel" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Sexe :"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="CIN : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_cin" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Date De Creation :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button class="PBTN" ID="Button10" runat="server" Text="Modifier" OnClick="Button10_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button class="PBTN" runat="server" Text="Réinitialiser" OnClick="Unnamed1_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
