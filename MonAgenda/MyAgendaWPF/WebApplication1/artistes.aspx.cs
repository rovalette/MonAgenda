using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class artistes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ServiceAgenda.ServiceAgendaClient service = new ServiceAgenda.ServiceAgendaClient();

                ListeArtiste.DataSource = service.getAllArtistes();
                ListeArtiste.DataTextField = "Name";
                ListeArtiste.DataValueField = "Guid";
                ListeArtiste.DataBind();
            }
        }

        protected void ListeArtiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("Evenements.aspx?IDARTIST=" + ListeArtiste.SelectedValue);
        }
    }
}