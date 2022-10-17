using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Comm
{
    public partial class ReadQueryString : System.Web.UI.Page
    {
        string[] furniture = { "Sofa 12000 rs", "Chair 999 rs" };
        string[] eletronics = { "Sony LED 45000 rs", "Intex LCD 22000 rs" };
        string[] camera = { "Sony 56000", "Nikon 45000" };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string str = Request.QueryString["category"];
                if (str == "Furniture")
                {
                    BulletedList1.DataSource = furniture;
                }
               else if (str == "Electronics")
                {
                    BulletedList1.DataSource = eletronics;
                }
                else if (str == "Camera")
                {
                    BulletedList1.DataSource = camera;
                }
                BulletedList1.DataBind();
            }
        }
    }
}