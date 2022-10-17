using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Comm
{
    public partial class ViewCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //code for read cookie

                //HttpCookie cookie = Request.Cookies["productlist"];
                // for (int i = 0; i < cookie.Values.Count; i++)
                // {
                //     CheckBoxList1.Items.Add(cookie.Values[i]);
                // }
                // code to read from session
                //read from profile
                //list = Profile.ProductList;
                if (Session["plist"] != null)
                {
                    ArrayList list = new ArrayList();
                    list = (ArrayList)Session["plist"];
                    CheckBoxList1.DataSource = list;
                    CheckBoxList1.DataBind();
                    lblMsg.Text = "";
                }
                else
                {
                    lblMsg.Text = "No items in the cart";
                }
            }
        }

        protected void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (!item.Selected)
                {
                    list.Add(item.Text);
                }
            }
            CheckBoxList1.Items.Clear();
            CheckBoxList1.DataSource = list;
            CheckBoxList1.DataBind();
        }
    }
}