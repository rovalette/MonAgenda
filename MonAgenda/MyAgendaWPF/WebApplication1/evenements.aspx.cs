using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class evenements : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ServiceAgenda.ServiceAgendaClient service = new ServiceAgenda.ServiceAgendaClient();

                ServiceAgenda.ArtisteWS Artiste = service.getArtiste(Request.QueryString["IDARTIST"]);
                listEvents.DataSource = service.getEvenementsByArtiste(Artiste);
                listEvents.DataTextField = "Titre";
                listEvents.DataValueField = "Guid";
                listEvents.DataBind();
            }
        }

        protected void listEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("Lieux.aspx?IDEVENT=" + listEvents.SelectedValue);
        }
    }
}