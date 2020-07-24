<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Annuler_Ticket.aspx.cs" Inherits="Gestion_Reservation.Annuler_Ticket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
            .BTNANNULER
      {
          background-color:cornflowerblue;
          color:white;
          font-size:12px;
          border-radius:3px;
  font-weight:bold;
 
 
      }
         .BTNANNULER:hover{
  background:#ff0000;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="ID RESERVATION"></asp:Label>
&nbsp;:</td>
            <td>
                <asp:TextBox ID="txt_id" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button10" class="BTNANNULER" runat="server" Text="Annuler la reservation" OnClick="Button10_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
