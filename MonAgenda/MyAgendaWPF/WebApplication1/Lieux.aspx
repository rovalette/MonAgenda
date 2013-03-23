<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/page.Master" CodeBehind="Lieux.aspx.cs" Inherits="WebApplication1.Lieux" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="planfialaire" ContentPlaceHolderID="PLAN" runat="server">
    <table>
        <tr>
            <td>
                <p>
                    <a href="Javascript:history.go(-3)">Accueil</a> &nbsp <img src="fleche_droite.gif" /> &nbsp <a href="Javascript:history.go(-2)">Recherche</a> &nbsp <img src="fleche_droite.gif" /> &nbsp <a href="Javascript:history.go(-1)">Evenement</a> &nbsp <img src="fleche_droite.gif" /> &nbsp Lieu
                </p>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListBox AutoPostBack="true" ID="listLieux" runat="server" OnSelectedIndexChanged="listLieux_SelectedIndexChanged"/>
</asp:Content>