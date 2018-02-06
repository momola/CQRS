using System.Collections.Generic;

public class AddRecipe: IEvent
{
    public string Name { get; }
    public string Description { get; }
    public string Component { get; }


    public AddRecipe(string Name, string Description, string Component)
    {
        this.Name = Name;
        this.Description = Description;
        this.Component = Component;
    }
}