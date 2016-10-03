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
            Global.Recipes.Add(new Recipe("Scalloped Potatoe", "Preheat oven to 375 degrees F (190 degrees C). Grease a large casserole dish." +
                        "In a medium mixing bowl combine the Cheddar cheese soup, onions and black pepper." +
                        "Slice the potato into 1 / 4 inch slices.Arrange one layer of sliced potatoes in the bottom of the casserole dish.Spoon one layer of soup over the potatoes.Arrange another layer of potatoes and then more soup.Continue layering until all of the ingredients have been used.Sprinkle the Cheddar cheese over the top of the casserole." +
                        "Bake until the cheese is bubbly and the potatoes fully cooked; approximately 45 minutes."));
            Global.Recipes.Add(new Recipe("Roast Sticky Chicken-Rotisserie Style", "In a small bowl, mix together salt, paprika, onion powder, thyme, white pepper, black pepper, cayenne pepper, and garlic powder. Remove and discard giblets from chicken. Rinse chicken cavity, and pat dry with paper towel. Rub each chicken inside and out with spice mixture. Place 1 onion into the cavity of each chicken. Place chickens in a resealable bag or double wrap with plastic wrap. Refrigerate overnight, or at least 4 to 6 hours." +
                        "Preheat oven to 250 degrees F(120 degrees C)." +
                        "Place chickens in a roasting pan.Bake unScovered for 5 hours, to a minimum internal temperature of 180 degrees F(85 degrees C). Let the chickens stand for 10 minutes before carving."));
        }
    }
}