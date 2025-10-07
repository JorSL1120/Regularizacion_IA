using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Tilemaps;

public enum FloorType { Stairs, Floor, Platforms }
public class Map
{
    private string _name;
    private Vector2Int _originCoordinates;
    private Vector2Int _size;

    private FloorType _type;
    private Tilemap _tilemap;

    public Map(string name, Vector2Int originCoordinates, Vector2Int size, Tilemap tilemap, FloorType type)
    {
        _name = name;
        _originCoordinates = originCoordinates;
        _size = size;
        _tilemap = tilemap;
        _type = type;
    }

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public Vector2Int OriginCoordinates
    {
        get
        {
            return _originCoordinates;
        }
    }

    public Vector2Int Size
    {
        get
        {
            return _size;
        }
    }

    public List<Vector3Int> generateCoordinates()
    {
        List<Vector3Int> coordenadas = new List<Vector3Int>();
        switch(_type)
        {
            case FloorType.Floor:
                for (int x = _originCoordinates.x; x < _size.x; x++)
                {
                    for(int y = _originCoordinates.y; y < _size.y; y++)
                    {
                        if(x == y) coordenadas.Add(new Vector3Int(x, y, 0));
                    }
                }
                return coordenadas;

            case FloorType.Platforms:
                return coordenadas;

            case FloorType.Stairs:
                return coordenadas;
        }
        return coordenadas;
    }

    public void Render(List<Vector3Int> coordenadas, Tile tile, Tilemap tilemap)
    {
        for (int i = 0; i < coordenadas.Count; i++)
        {
            tilemap.SetTile(coordenadas[i], tile);
        }
    }
}
