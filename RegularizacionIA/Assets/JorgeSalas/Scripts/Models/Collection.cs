using UnityEngine;

public class Collection
{
    private string name;
    private int cost;

    public Collection(string name, int cost)
    {
        this.name = name;
        this.cost = cost;
    }

    public string Name
    {
        get
        {
            return name;
        }
    }

    public int Cost
    {
        get
        {
            return cost;
        }
    }
}
