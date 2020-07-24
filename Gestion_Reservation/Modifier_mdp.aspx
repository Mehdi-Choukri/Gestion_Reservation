<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Modifier_mdp.aspx.cs" Inherits="Gestion_Reservation.Modifier_mdp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style6 {
        width: 100%;
    }
    .BTNMODIFIER
      {
          background-color:cornflowerblue;
          color:white;
          font-size:10px;
          border-radius:5px;
  font-weight:bold;
 
 
      }
         .BTNMODIFIER:hover{
  background:#ff0000;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Ancien Password :"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_ap" runat="server"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" ForeColor="#FF3300"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Nouveau Password :"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_NP" runat="server"></asp:TextBox>
            <asp:Label ID="Label8" runat="server" ForeColor="#FF3300"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Confirmer Votre Password:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_cp" runat="server"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" ForeColor="#FF3300"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button class="BTNMODIFIER" ID="Button10" runat="server" Text="Modifier" OnClick="Button10_Click" />
        </td>
        <td>
            <asp:Label ID="Label7" runat="server" ForeColor="#009933"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
