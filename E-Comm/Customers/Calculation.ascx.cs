using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Comm.Customers
{
    public partial class Calculaation : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtfirst.Text);
            int b = Convert.ToInt32(txtsecond.Text);
            int c = a + b;
            txtresult.Text = c.ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtfirst.Text);
            int b = Convert.ToInt32(txtsecond.Text);
            int c = a - b;
            txtresult.Text = c.ToString();
        }
    }
}