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
            Global.Recipes.Add(new Recipe("Hamburger Steak with Onions and Gravy", "In a large bowl, mix together the ground beef, egg, bread crumbs, pepper, salt, onion powder, garlic powder, and Worcestershire sauce. Form into 8 balls, and flatten into patties." +
                        "Heat the oil in a large skillet over medium heat.Fry the patties and onion in the oil until patties are nicely browned, about 4 minutes per side.Remove the beef patties to a plate, and keep warm. " +
                        "Sprinkle flour over the onions and drippings in the skillet.Stir in flour with a fork, scraping bits of beef off of the bottom as you stir.Gradually mix in the beef broth and sherry.Season with seasoned salt.Simmer and stir over medium - low heat for about 5 minutes, until the gravy thickens.Turn heat to low, return patties to the gravy, cover, and simmer for another 15 minutes."));
            Global.Recipes.Add(new Recipe("Fried potatoes", "Do something, bla-bla"));
            Global.Recipes.Add(new Recipe("Boiled potatoes", "Do something, bla-bla"));
        }
    }
}