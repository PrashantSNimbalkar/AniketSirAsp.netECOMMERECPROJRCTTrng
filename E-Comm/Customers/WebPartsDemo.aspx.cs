using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace E_Comm.Customers
{
    public partial class WebPartsDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbCatalog_Click(object sender, EventArgs e)
        {
            WebPartManager1.DisplayMode = WebPartManager.CatalogDisplayMode;
        }

        protected void lbEditor_Click(object sender, EventArgs e)
        {
            WebPartManager1.DisplayMode = WebPartManager.EditDisplayMode;
        }

        protected void lbDesign_Click(object sender, EventArgs e)
        {
            WebPartManager1.DisplayMode = WebPartManager.DesignDisplayMode;
        }
    }
}