using UnityEngine;

public class Map
{
    private string name;
    private Vector2Int originCoordinates;
    private Vector2Int size;

    public Map(string name, Vector2Int originCoordinates, Vector2Int size)
    {
        this.name = name;
        this.originCoordinates = originCoordinates;
        this.size = size;
    }

    public string Name
    {
        get
        {
            return name;
        }
    }

    public Vector2Int OriginCoordinates
    {
        get
        {
            return originCoordinates;
        }
    }

    public Vector2Int Size
    {
        get
        {
            return size;
        }
    }
}
