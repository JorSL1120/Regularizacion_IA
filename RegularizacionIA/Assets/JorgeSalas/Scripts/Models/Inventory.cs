using UnityEngine;
using System.Collections.Generic;

public class Inventory
{
    public string name;
    public List<Collection> objectsList;

    public Inventory(string name, List<Collection> objectsList)
    {
        this.name = name;
        this.objectsList = objectsList;
    }
}
