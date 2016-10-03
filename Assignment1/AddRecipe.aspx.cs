using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class AddRecipe : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RecipeSave(object sender, EventArgs e)
        {
            Global.Recipes.Add(new Recipe(RecipeInputName.Value, RecipeInputDescription.Value));
            SuccessfullySaved.Text = "You succesfully saved your recipe!";
        }
    }
}