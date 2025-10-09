 using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Tilemaps;

public enum MapNum { Area1, Area2, Area3, Area4, Area5, Area6 }
public class Map
{
    private string _name;
    private Vector2Int _originCoordinates;
    private Vector2Int _size;
    private Tilemap _tilemap;

    private MapNum _mapNum;

    public Map(string name, Vector2Int originCoordinates, Vector2Int size, Tilemap tilemap, MapNum mapNum)
    {
        _name = name;
        _originCoordinates = originCoordinates;
        _size = size;
        _tilemap = tilemap;
        _mapNum = mapNum;
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

    public List<Vector3Int> GenerateCoordinates()
    {
        List<Vector3Int> coordenadasAreas = new List<Vector3Int>();
        switch(_mapNum)
        {
            case MapNum.Area1:
                for (int x = _originCoordinates.x; x < _size.x; x++)
                {
                    for(int y = _originCoordinates.y; y < _size.y; y++)
                    {
                        coordenadasAreas.Add(new Vector3Int(x, y, 0));
                    }
                }
                return coordenadasAreas;

            case MapNum.Area2:
                for (int x = _originCoordinates.x; x < _size.x; x++)
                {
                    for (int y = _originCoordinates.y; y < _size.y; y++)
                    {
                        coordenadasAreas.Add(new Vector3Int(x + _size.x, y, 0));
                    }
                }
                return coordenadasAreas;

            case MapNum.Area3:
                for (int x = _originCoordinates.x; x < _size.x; x++)
                {
                    for (int y = _originCoordinates.y; y < _size.y; y++)
                    {
                        coordenadasAreas.Add(new Vector3Int(x + _size.x, y, 0));
                    }
                }
                return coordenadasAreas;

            case MapNum.Area4:
                for (int x = _originCoordinates.x; x < _size.x; x++)
                {
                    for (int y = _originCoordinates.y; y < _size.y; y++)
                    {
                        if(x == y) coordenadasAreas.Add(new Vector3Int(x + _size.x, y, 0));
                    }
                }
                return coordenadasAreas;

            case MapNum.Area5:
                for (int x = _originCoordinates.x; x < _size.x; x++)
                {
                    for (int y = _originCoordinates.y; y < _size.y; y++)
                    {
                        coordenadasAreas.Add(new Vector3Int(x + _size.x, y, 0));
                    }
                }
                return coordenadasAreas;
        }
        return coordenadasAreas;
    }

    public List<Vector3Int> GeneratePlatforms()
    {
        List<Vector3Int> coordenadasPlatform = new List<Vector3Int>();
        switch (_mapNum)
        {
            case MapNum.Area1:
                for(int numPlatA1 = 0; numPlatA1 < 6; numPlatA1++)
                {
                    int widhtA1 = Random.Range(_originCoordinates.x, _size.x);
                    int heightA1 = Random.Range(_originCoordinates.y, 10);
                    Vector2Int pivot = new Vector2Int(widhtA1, heightA1);

                    for (int x = pivot.x; x < 4; x++)
                    {
                        for (int y = pivot.y; y < 2; y++)
                        {
                            coordenadasPlatform.Add(new Vector3Int(x, y, 0));
                        }
                    }
                    widhtA1 = 0;
                    heightA1 = 0;
                }
                return coordenadasPlatform;

            case MapNum.Area2:
                for (int numPlatA2 = 0; numPlatA2 < 6; numPlatA2++)
                {
                    int widhtA2 = Random.Range(_originCoordinates.x, _size.x);
                    int heightA2 = Random.Range(_originCoordinates.y, 10);
                    Vector2Int pivot = new Vector2Int(widhtA2, heightA2);

                    for (int x = pivot.x; x < 4; x++)
                    {
                        for (int y = pivot.y; y < 2; y++)
                        {
                            coordenadasPlatform.Add(new Vector3Int(x, y, 0));
                        }
                    }
                    widhtA2 = 0;
                    heightA2 = 0;
                }
                return coordenadasPlatform;

            case MapNum.Area3:
                for (int numPlat = 0; numPlat < 6; numPlat++)
                {
                    int widhtA1 = Random.Range(_originCoordinates.x, _size.x);
                    int heightA1 = Random.Range(_originCoordinates.y, 10);
                    Vector2Int pivot = new Vector2Int(widhtA1, heightA1);

                    for (int x = pivot.x; x < 4; x++)
                    {
                        for (int y = pivot.y; y < 2; y++)
                        {
                            coordenadasPlatform.Add(new Vector3Int(x, y, 0));
                        }
                    }
                    widhtA1 = 0;
                    heightA1 = 0;
                }
                return coordenadasPlatform;

            case MapNum.Area4:
                for (int numPlat = 0; numPlat < 6; numPlat++)
                {
                    int widhtA1 = Random.Range(_originCoordinates.x, _size.x);
                    int heightA1 = Random.Range(_originCoordinates.y, 10);
                    Vector2Int pivot = new Vector2Int(widhtA1, heightA1);

                    for (int x = pivot.x; x < 4; x++)
                    {
                        for (int y = pivot.y; y < 2; y++)
                        {
                            coordenadasPlatform.Add(new Vector3Int(x, y, 0));
                        }
                    }
                    widhtA1 = 0;
                    heightA1 = 0;
                }
                return coordenadasPlatform;

            case MapNum.Area5:
                for (int numPlat = 0; numPlat < 6; numPlat++)
                {
                    int widhtA1 = Random.Range(_originCoordinates.x, _size.x);
                    int heightA1 = Random.Range(_originCoordinates.y, 10);
                    Vector2Int pivot = new Vector2Int(widhtA1, heightA1);

                    for (int x = pivot.x; x < 4; x++)
                    {
                        for (int y = pivot.y; y < 2; y++)
                        {
                            coordenadasPlatform.Add(new Vector3Int(x, y, 0));
                        }
                    }
                    widhtA1 = 0;
                    heightA1 = 0;
                }
                return coordenadasPlatform;
        }
        return coordenadasPlatform;
    }

    public void Render(List<Vector3Int> coordenadas, Tile tile, Tilemap tilemap)
    {
        for (int i = 0; i < coordenadas.Count; i++)
        {
            tilemap.SetTile(coordenadas[i], tile);
        }
    }
}
