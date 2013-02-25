using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class index : System.Web.UI.Page
    {
        protected SiteMapDataSource _siteMapDataSource1;
        protected void Page_Load(object sender, EventArgs e)
        {
            _siteMapDataSource1 = new SiteMapDataSource();
        }
    }
}