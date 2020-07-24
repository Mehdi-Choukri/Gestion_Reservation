<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Creation_compte.aspx.cs" Inherits="Gestion_Reservation.Creation_compte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            height: 30px;
            }
        .auto-style8 {
            width: 35px;
            height: 35px;
        }
        .auto-style9 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="create_form" >
    <table class="auto-style1">
    <tr>
        <td>
            <img alt="" class="auto-style8" src="Icons/plus.png" /></td>
    </tr>
    <tr>
        <td class="auto-style9">
            <asp:TextBox class="create_content_form" ID="txt_nom" placeholder="Nom et Prenom" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ErrorMessage="*" ForeColor="#0099FF" ControlToValidate="txt_nom"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox class="create_content_form" ID="txt_user" placeholder="Nom de l'utilisateur" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_user" Display="Dynamic" ErrorMessage="*" ForeColor="#0099FF"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:TextBox ID="txt_mail" class="create_content_form" placeholder="Email" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_mail" Display="Dynamic" ErrorMessage="*" ForeColor="#0099FF"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_mail" Display="Dynamic" ErrorMessage="Mail Incorrect" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Calendar ID="Calendar1" class="create_content_form" runat="server"></asp:Calendar>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txt_pw" class="create_content_form" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_pw" Display="Dynamic" ErrorMessage="*" ForeColor="#0099FF"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txt_adresse" class="create_content_form" placeholder="Adresse" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txt_adresse" Display="Dynamic" ErrorMessage="*" ForeColor="#0099FF"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txt_tel" class="create_content_form" placeholder="N° Telephone" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txt_tel" Display="Dynamic" ErrorMessage="*" ForeColor="#0099FF"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_tel" Display="Dynamic" ErrorMessage="Telephone Incorrect" ForeColor="Red" ValidationExpression="[0]{1}[5-6-7]{1}[0-9]{8}"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DropDownList1" Display="Dynamic" ErrorMessage="*" ForeColor="#0099FF"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txt_cin" class="create_content_form" placeholder="CIN" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txt_cin" Display="Dynamic" ErrorMessage="*" ForeColor="#0099FF"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txt_cin" Display="Dynamic" ErrorMessage=" CIN Incorrect" ForeColor="Red" ValidationExpression="[a-z A-Z]{2}[0-9]{6}"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txt_pf" class="create_content_form" placeholder="Le montant de votre Portfeuille" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txt_pf" Display="Dynamic" ErrorMessage="*" ForeColor="#0099FF"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button class="btn_creation" ID="Button6" runat="server" Text="Creer" OnClick="Button6_Click" />
            <asp:Button class="btn_creation" ID="Button7" runat="server" Text="Annuler" OnClick="Button7_Click" />
            <br />
        </td>
    </tr>
</table>
        </div>
</asp:Content>
