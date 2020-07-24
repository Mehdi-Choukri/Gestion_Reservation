<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Form_Recherche.aspx.cs" Inherits="Gestion_Reservation.Form_Recherche" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        h4{
            text-align:left;
            color :#ff0000;
        }
        .BTNChercher
      {
          background-color:cornflowerblue;
          color:white;
          font-size:12px;
          border-radius:3px;
  font-weight:bold;
 
 
      }
         .BTNChercher:hover{
  background:#ff0000;
}
         
        style7 {
            width:100% ;
            height:100%;
           
        }
         
                
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr>
            <td>
                <h4>Depart</h4>
            </td>
            <td>
                 <h4>Arriver</h4>
            </td>
            <td>
                <h4>Date de depart</h4>
            </td>
            <td>
                 <h4>Heure de depart</h4>
            </td>
            <td>
                 <h4>Nombre de Sieges a reservés</h4>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="drop_villeD" runat="server" BackColor="#6699FF">
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="drop_villeA" runat="server" BackColor="#6699FF" ForeColor="Black">
                </asp:DropDownList>
            </td>
            <td>
                <asp:TextBox ID="txt_date" placeholder="JJ-MM-AAAA" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="Heure_dep" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:DropDownList ID="nbr_siege" runat="server" BackColor="#6699FF">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button10" class="BTNChercher" runat="server" Text="Chercher" OnClick="Button10_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Avion_ReservationConnectionString %>" SelectCommand="Recherche_Vol_SP" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="drop_villeD" Name="P_ville_depart" PropertyName="SelectedValue" Type="String" />
                        <asp:ControlParameter ControlID="drop_villeA" Name="P_ville_Arriver" PropertyName="SelectedValue" Type="String" />
                        <asp:ControlParameter ControlID="txt_date" Name="p_Date_depart" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="Heure_dep" Name="p_Heure_depart" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="nbr_siege" Name="P_Siege" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataKeyNames="Vol_ID" DataSourceID="SqlDataSource1" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" class="style7">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="Vol_ID" HeaderText="Vol_ID" ReadOnly="True" SortExpression="Vol_ID" />
                        <asp:BoundField DataField="Com_Name" HeaderText="Com_Name" SortExpression="Com_Name" />
                        <asp:BoundField DataField="Depart_Date" HeaderText="Depart_Date" SortExpression="Depart_Date" />
                        <asp:BoundField DataField="Depart_ville" HeaderText="Depart_ville" SortExpression="Depart_ville" />
                        <asp:BoundField DataField="Depart_Time" HeaderText="Depart_Time" SortExpression="Depart_Time" />
                        <asp:BoundField DataField="Arrive_ville" HeaderText="Arrive_ville" SortExpression="Arrive_ville" />
                        <asp:BoundField DataField="Arrival_Time" HeaderText="Arrival_Time" SortExpression="Arrival_Time" />
                        <asp:BoundField DataField="PrixHT" HeaderText="PrixHT" SortExpression="PrixHT" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
        </tr>
    </table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
</asp:Content>
