<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="evenements.aspx.cs" Inherits="WebApplication1.evenements" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="planfialaire" ContentPlaceHolderID="PLAN" runat="server">
    <table>
        <tr>
            <td>
                <p>
                    <a href="Javascript:history.go(-2)">Accueil</a> &nbsp <img src="fleche_droite.gif" /> &nbsp <a href="Javascript:history.go(-1)">Recherche</a> &nbsp <img src="fleche_droite.gif" /> &nbsp Evenement
                </p>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListBox AutoPostBack="true" ID="listEvents" runat="server" OnSelectedIndexChanged="listEvents_SelectedIndexChanged" />
</asp:Content>
