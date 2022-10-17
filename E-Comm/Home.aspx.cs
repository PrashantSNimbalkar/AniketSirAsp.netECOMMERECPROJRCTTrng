using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Comm
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = (int)Application["vCount"];
            Application.Lock();
            count++;
            Application["vCount"] = count;
            Application.UnLock();
            lblVisitCount.Text = "You are the Visitor number " + Application["vCount"].ToString();
        }
    }
}