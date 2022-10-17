using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Comm.Admin
{
    public partial class ManageRoles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               var list= Membership.GetAllUsers();
                DropDownList1.DataSource = list;
                DropDownList1.DataBind();
            }
        }

        protected void btnAddRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (Roles.RoleExists(txtRole.Text))
                {
                    lblMsg.Text = "Role already exits";
                }
                else
                {
                    Roles.CreateRole(txtRole.Text);
                    lblMsg.Text = "Successfully added the Role " + txtRole.Text;
                }
            }
            catch(Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        protected void btnAddUserToRole_Click(object sender, EventArgs e)
        {
            try
            {
                string username = DropDownList1.SelectedItem.Text;
                Roles.AddUserToRole(username, txtRole.Text);
                lblMsg.Text = username + " added to role " + txtRole.Text;
               
            }
            catch(Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }
    }
}