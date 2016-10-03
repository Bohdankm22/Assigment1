using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class Recipes : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        { 
            ListView1.DataSource = Global.Recipes;
            ListView1.DataBind();      
        }
    }
}