using UnityEngine;
using System.Collections.Generic;

public class Inventory
{
    private string name;
    private List<Collection> objectsList;

    public Inventory(string name, List<Collection> objectsList)
    {
        this.name = name;
        this.objectsList = objectsList;
    }

    public string Name
    {
        get
        {
            return name;
        }
    }

    public List<Collection> ObjectsList
    {
        get
        {
            return objectsList;
        }
    }
}
