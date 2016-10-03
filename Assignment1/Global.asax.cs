using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Assignment1
{
    public class Global : HttpApplication
    {

        static List<Recipe> recipes;
        public static List<Recipe> Recipes
        {
            get
            {
                return recipes;
            }

            set
            {
                recipes = value;
            }
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Global.Recipes = new List<Recipe>();
            Global.Recipes.Add(new Recipe("Smashed potatoes", "Do something, bla-bla"));
            Global.Recipes.Add(new Recipe("Fried potatoes", "Do something, bla-bla"));
            Global.Recipes.Add(new Recipe("Boiled potatoes", "Do something, bla-bla"));
        }
    }
}