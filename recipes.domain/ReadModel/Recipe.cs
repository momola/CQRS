using System.Collections.Generic;

public class Recipe
{
    public string Name { get; }
    public string Description { get; }
    public string Component { get; }


    public Recipe(string Name, string Description, string Component)
    {
        this.Name = Name;
        this.Description = Description;
        this.Component = Component;
    }
}