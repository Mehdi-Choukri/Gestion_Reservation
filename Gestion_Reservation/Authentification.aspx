<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Authentification.aspx.cs" Inherits="Gestion_Reservation.Authentification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
       


       
    .auto-style6 {
        width: 70px;
    }
    

       
        .auto-style9 {
            width: 271px;
            margin: 100px auto;
            padding: 10px;
            -webkit-box-shadow: 0 1px 2px rgba(0,0,0,0.2);
            background: #fff;
        }


       
        .auto-style10 {
            width: 35px;
            height: 35px;
        }


       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet"  href="Feuille_style.css" type="text/css" />
    <div class="auto-style9">

    
    <table  class="auto-style4">
        <tr>
            <td class="auto-style2" colspan="2">
                <img alt="" class="auto-style10" src="Icons/user.png" /></td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="2">
                <br />
                <asp:TextBox class="login_content_form" ID="txt_login" placeholder="Login"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="txt_pw" class="login_content_form" placeholder="Password" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button8" class="login_btn" runat="server" Text="Connexion" OnClick="Button8_Click" />
            </td>
            <td class="auto-style6">
                <asp:Button ID="Button9" class="login_btn" runat="server" Text="Annuler" />
            </td>
        </tr>
        <tr><td colspan="2"> 
            <a href="#" title="">Mots de passe Oublier ?</a>
            <div>
    <a href="Creation_compte.aspx" title="">Vous n'avez pas encore de compte?</a>
    <a href="Authentification.aspx" title="">Connecter Vous</a>
  </div></td></tr>
    </table>
        </div>
  

</asp:Content>
