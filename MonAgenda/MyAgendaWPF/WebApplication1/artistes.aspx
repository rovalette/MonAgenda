<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="artistes.aspx.cs" Inherits="WebApplication1.artistes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="planfialaire" ContentPlaceHolderID="PLAN" runat="server">
    <table>
        <tr>
            <td>
                <p>
                    <a href="javascript:history.back()">Accueil</a> &nbsp <img src="fleche_droite.gif" /> &nbsp Recherche
                </p>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListBox AutoPostBack="true" ID="ListeArtiste" runat="server" OnSelectedIndexChanged="ListeArtiste_SelectedIndexChanged"/> 
</asp:Content>
