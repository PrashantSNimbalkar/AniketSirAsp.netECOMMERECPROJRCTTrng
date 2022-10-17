using E_Comm.Customers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Comm
{
    public partial class ListByCategory : System.Web.UI.Page
    {
       // string[] categories = { "Furniture", "Electronics", "Camera", "Home Needs" };
        string[] furniture = { "Sofa 12000 rs", "Chair 999 rs","Two Chair 1999" };
        string[] eletronics = { "Sony LED 45000 rs", "Intex LCD 22000 rs","LG Washing Machine 45000" };
        string[] camera = { "Sony 56000", "Nikon 45000" };
        protected void Page_Load(object sender, EventArgs e)
        {
            // exec the code only for the first time page get load/ on sub sequent req we dont want to exe
            // the code
            if (!Page.IsPostBack)
            {
                CategoryDAL db = new CategoryDAL();
                List<Category> list = db.GetAllCategories();
                ddlCategories.DataSource = list;
                ddlCategories.DataTextField = "CategoryName";
                ddlCategories.DataValueField = "CategoryId";
                
            }
            Page.DataBind();
            
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            // code for cookies
            //int counter = 0;
            //string data = "Selected products ";
            //HttpCookie cookie = new HttpCookie("productlist");

            //foreach (ListItem item in CheckBoxList1.Items)
            //{
            //    string str = "p";
            //    if (item.Selected)
            //    {
            //        counter++;
            //        ViewState["pcount"] = counter;
            //        data += item.Text + "  ";
            //        str = str + counter.ToString();
            //        cookie.Values.Add(str, item.Text);
            //    }
            //}
            //// set the cookie
            //Response.Cookies.Add(cookie);
            ////Response.Redirect("~/ViewCart.aspx");
            //lblMsg.Text = data;
            //lblProductCount.Text = "Total number of products " + ViewState["pcount"];

            // code for session
            ArrayList list = new ArrayList();
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    list.Add(item.Text);
                }
            }
            // data caching
            Cache.Add("plist", list, null, DateTime.Now.AddMinutes(20), TimeSpan.FromSeconds(0),
                System.Web.Caching.CacheItemPriority.High, null);
            // Insert- > same key cache will be override
            //Cache.Insert("plist", list, null, DateTime.Now.AddMinutes(20), TimeSpan.FromSeconds(120),
            //   System.Web.Caching.CacheItemPriority.High, null);
            Session["plist"] = list;
            // Profile.ProductList = list;
            Response.Redirect("~/Customers/ViewCart.aspx");
        }

        protected void ddlCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  CheckBoxList1.Items.Clear();

            string category = ddlCategories.SelectedItem.ToString();
           
                if (category == "Furniture")
                {
                    CheckBoxList1.DataSource = furniture;
                }
                else if (category == "Electronics")
                {
                    CheckBoxList1.DataSource = eletronics;
                }
                else if (category == "Camera")
                {
                    CheckBoxList1.DataSource = camera;
                }
            CheckBoxList1.DataBind();
            
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}