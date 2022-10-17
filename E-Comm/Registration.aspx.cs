using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_Comm.App_Code;
namespace E_Comm
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.FirstName = txtFirstName.Text;
            users.LastName = txtLastName.Text;
            users.UserName = txtEmail.Text;
            users.Email = txtEmail.Text;
            users.Password = txtPassword.Text;
            UsersDAL dal = new UsersDAL();
           int res= dal.SaveNewUser(users);
            if(res == 1){
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                lblMessage.Text = "Fail";
            }
        }
    }
}