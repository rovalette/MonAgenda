using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Lieux : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ServiceAgenda.ServiceAgendaClient service = new ServiceAgenda.ServiceAgendaClient();

                listLieux.DataSource = service.getLieuxEvents(Request.QueryString[0]);
                listLieux.DataTextField = "Name";
                listLieux.DataValueField = "Guid";
                listLieux.DataBind();
            }
        }

        protected void listLieux_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Response.Redirect("");
        }
    }
}