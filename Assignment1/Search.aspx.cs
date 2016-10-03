using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchRecipes(object sender, EventArgs e)
        {
            List<Recipe> result = new List<Recipe>();
            string pattern = searchLine.Value;
            foreach (Recipe item in Global.Recipes)
            {
                if (item.Name.ToLower().Contains(pattern.ToLower()) || item.Description.ToLower().Contains(pattern.ToLower()))
                {
                    result.Add(item);
                }
            }
            ListView1.DataSource = result;
            ListView1.DataBind();
        }
    }
}