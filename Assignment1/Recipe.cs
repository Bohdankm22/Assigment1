namespace Assignment1
{
    internal class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Recipe (string name, string description)
        {
            Name = name;
            Description = description;  
        }
    }

}