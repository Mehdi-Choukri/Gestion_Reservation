<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="Gestion_Reservation.Contacts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        #TextArea1 {
            height: 42px;
            width: 193px;
        }
        .auto-style7 {
            width: 653px;
        }
        .auto-style8 {
            width: 50px;
            height: 50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="create_form" >
          <img alt="" class="auto-style8" src="Icons/email.png" /><br />
    <table class="auto-style6">
        <tr>
            <td class="auto-style7">
                <asp:TextBox class="create_content_form" placeholder="Votre nom" ID="txt_nom" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:TextBox class="create_content_form" placeholder="Votre Email" ID="txt_mail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_mail" Display="Dynamic" ErrorMessage="*" ForeColor="#0033CC"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <textarea class="create_content_form" runat="server" placeholder="Votre Message" id="txt_msg" name="S1"></textarea><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_msg" Display="Dynamic" ErrorMessage="*" ForeColor="Blue"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Button ID="Button11" class="btn_creation" runat="server" Text="Envoyer" OnClick="Button11_Click" />
            </td>
        </tr>
    </table>
          <asp:Label ID="Label1" runat="server"></asp:Label>
          <br />
          </div>
</asp:Content>
