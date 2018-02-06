using System.Collections.Generic;
using recipes.domain;

public class SearchRecipe : Query
{
    public string Name { get; }
    public string Description { get; }
    public string Component { get; }


    public SearchRecipe(string Name, string Description, string Component)
    {
        this.Name = Name;
        this.Description = Description;
        this.Component = Component;
    }
}