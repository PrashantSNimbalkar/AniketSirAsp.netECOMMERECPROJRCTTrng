using E_Comm.Admin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Comm
{
    public partial class sampleBootstrapDemo : System.Web.UI.Page
    {
        int flag = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        private void ShowData()
        {
           
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            flag = 0;
            ProductDAL dal = new ProductDAL();
            var prod = dal.GetAllProducts();
            GridView1.DataSource = prod;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            flag = 1;
            ProductDAL dal = new ProductDAL();
            var prod = dal.GetAllProducts();
            GridView1.DataSource = prod;
            GridView1.DataBind();
           
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (flag == 0)
            {
                e.Row.Cells[1].Visible = false;
                e.Row.Cells[2].Visible = true;
            }
            else if (flag == 1)
            {
                e.Row.Cells[1].Visible = true;
                e.Row.Cells[2].Visible = false;
            }
        }
    }
}