using UnityEngine;

public class Map
{
    public string name;
    public Vector2Int originCoordinates;
    public Vector2Int size;

    public Map(string name, Vector2Int originCoordinates, Vector2Int size)
    {
        this.name = name;
        this.originCoordinates = originCoordinates;
        this.size = size;
    }
}
