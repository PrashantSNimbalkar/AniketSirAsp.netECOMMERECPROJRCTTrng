using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Comm.App_Code
{
    public class CountedButton:System.Web.UI.WebControls.Button
    {
        public CountedButton()
        {
            this.Text = "Click Me";
            ViewState["count"] = 0;
        }
        public int Count
        {
            set
            {
                ViewState["count"] = value;
            }
            get
            {
                return (int)ViewState["count"];
            }
        }
        protected override void OnClick(EventArgs e)
        {
            ViewState["count"] = ((int)ViewState["count"]) + 1;
            this.Text = ViewState["count"] + " Clicks";
            base.OnClick(e);
        }
    }
}