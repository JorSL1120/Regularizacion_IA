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
                for (int x = 0; x < _size.x; x++)
                {
                    for(int y = 0; y < _size.y; y++)
                    {
                        coordenadasAreas.Add(new Vector3Int(x + _originCoordinates.x, y + _originCoordinates.y, 0));
                    }
                }
                return coordenadasAreas;

            case MapNum.Area2:
                for (int x = _originCoordinates.x; x < _size.x + _originCoordinates.x; x++)
                {
                    for (int y = _originCoordinates.y; y < _size.y + _originCoordinates.y; y++)
                    {
                        coordenadasAreas.Add(new Vector3Int(x, y, 0));
                    }
                }
                return coordenadasAreas;

            case MapNum.Area3:
                for (int x = _originCoordinates.x; x < _size.x + _originCoordinates.x; x++)
                {
                    for (int y = _originCoordinates.y; y < _size.y + _originCoordinates.y; y++)
                    {
                        coordenadasAreas.Add(new Vector3Int(x, y, 0));
                    }
                }
                return coordenadasAreas;

            case MapNum.Area4:
                for (int x = _originCoordinates.x; x < _size.x + _originCoordinates.x; x++)
                {
                    for (int y = _originCoordinates.y; y < _size.y + _originCoordinates.y; y++)
                    {
                        coordenadasAreas.Add(new Vector3Int(x, y, 0));
                    }
                }
                return coordenadasAreas;

            case MapNum.Area5:
                for (int x = _originCoordinates.x; x < _size.x + _originCoordinates.x; x++)
                {
                    for (int y = _originCoordinates.y; y < _size.y + _originCoordinates.y; y++)
                    {
                        coordenadasAreas.Add(new Vector3Int(x, y, 0));
                    }
                }
                return coordenadasAreas;
        }
        return coordenadasAreas;
    }

    public List<Vector3Int> GeneratePlatforms()
    {
        List<Vector3Int> coordenadasPlatform = new List<Vector3Int>();
        
        int numPlatforms;
        int platformWidth;
        int platformHeight;
        
        int originAreaX = _originCoordinates.x;
        int endAreaX = _originCoordinates.x + _size.x;
        int originAreaY = _originCoordinates.y;
        int heightStart = originAreaY + _size.y + 3;
        int heightLimit = heightStart;

        int pivotMaxX;
        int pivotMaxY;
        
        switch (_mapNum)
        {
            case MapNum.Area1:
                numPlatforms = 2;
                platformWidth = 3;
                platformHeight = 1;
                heightLimit += 10;
                
                pivotMaxX = endAreaX - platformWidth;
                pivotMaxY = heightLimit - platformHeight;
                
                for (int i = 0; i < numPlatforms; i++)
                {
                    int pivotX = Random.Range(originAreaX, pivotMaxX); 
                    int pivotY = Random.Range(heightStart, pivotMaxY); 

                    for (int x = 0; x < platformWidth; x++)
                    {
                        for (int y = 0; y < platformHeight; y++)
                        {
                            int worldX = pivotX + x;
                            int worldY = pivotY + y;

                            if (worldX < endAreaX)
                            {
                                coordenadasPlatform.Add(new Vector3Int(worldX, worldY, 0));
                            }
                        }
                    }
                }
                return coordenadasPlatform;
                

            case MapNum.Area2:
                numPlatforms = 5;
                platformWidth = 3;
                platformHeight = 1;
                heightLimit += 10;
                
                pivotMaxX = endAreaX - platformWidth;
                pivotMaxY = heightLimit - platformHeight;
                
                for (int i = 0; i < numPlatforms; i++)
                {
                    int pivotX = Random.Range(originAreaX, pivotMaxX); 
                    int pivotY = Random.Range(heightStart, pivotMaxY); 

                    for (int x = 0; x < platformWidth; x++)
                    {
                        for (int y = 0; y < platformHeight; y++)
                        {
                            int worldX = pivotX + x;
                            int worldY = pivotY + y;

                            if (worldX < endAreaX)
                            {
                                coordenadasPlatform.Add(new Vector3Int(worldX, worldY, 0));
                            }
                        }
                    }
                }
                return coordenadasPlatform;

            case MapNum.Area3:
                numPlatforms = 8;
                platformWidth = 3;
                platformHeight = 1;
                heightLimit += 10;
                
                pivotMaxX = endAreaX - platformWidth;
                pivotMaxY = heightLimit - platformHeight;
                
                for (int i = 0; i < numPlatforms; i++)
                {
                    int pivotX = Random.Range(originAreaX, pivotMaxX); 
                    int pivotY = Random.Range(heightStart, pivotMaxY); 

                    for (int x = 0; x < platformWidth; x++)
                    {
                        for (int y = 0; y < platformHeight; y++)
                        {
                            int worldX = pivotX + x;
                            int worldY = pivotY + y;

                            if (worldX < endAreaX)
                            {
                                coordenadasPlatform.Add(new Vector3Int(worldX, worldY, 0));
                            }
                        }
                    }
                }
                return coordenadasPlatform;

            case MapNum.Area4:
                numPlatforms = 10;
                platformWidth = 3;
                platformHeight = 1;
                heightLimit += 10;
                
                pivotMaxX = endAreaX - platformWidth;
                pivotMaxY = heightLimit - platformHeight;
                
                for (int i = 0; i < numPlatforms; i++)
                {
                    int pivotX = Random.Range(originAreaX, pivotMaxX); 
                    int pivotY = Random.Range(heightStart, pivotMaxY); 

                    for (int x = 0; x < platformWidth; x++)
                    {
                        for (int y = 0; y < platformHeight; y++)
                        {
                            int worldX = pivotX + x;
                            int worldY = pivotY + y;

                            if (worldX < endAreaX)
                            {
                                coordenadasPlatform.Add(new Vector3Int(worldX, worldY, 0));
                            }
                        }
                    }
                }
                return coordenadasPlatform;

            case MapNum.Area5:
                numPlatforms = 12;
                platformWidth = 3;
                platformHeight = 1;
                heightLimit += 10;
                
                pivotMaxX = endAreaX - platformWidth;
                pivotMaxY = heightLimit - platformHeight;
                
                for (int i = 0; i < numPlatforms; i++)
                {
                    int pivotX = Random.Range(originAreaX, pivotMaxX); 
                    int pivotY = Random.Range(heightStart, pivotMaxY); 

                    for (int x = 0; x < platformWidth; x++)
                    {
                        for (int y = 0; y < platformHeight; y++)
                        {
                            int worldX = pivotX + x;
                            int worldY = pivotY + y;

                            if (worldX < endAreaX)
                            {
                                coordenadasPlatform.Add(new Vector3Int(worldX, worldY, 0));
                            }
                        }
                    }
                }
                return coordenadasPlatform;
        }
        return coordenadasPlatform;
    }

    public List<Vector3Int> GenerateObstacles()
    {
        List<Vector3Int> coordenadasObstacle = new List<Vector3Int>();
        
        int widthObstacle = 3;
        int heightObstacle = 2;
        
        int originAreaX = _originCoordinates.x;
        int endAreaX = _originCoordinates.x + _size.x;
        int originAreaY = _originCoordinates.y;
        int heightStart = originAreaY + _size.y;
        
        int numObstacles;
        int pivotMaxX;
        
        switch (_mapNum)
        {
        case MapNum.Area1:
            numObstacles = 1;
            pivotMaxX = endAreaX - widthObstacle;

            for (int i = 0; i < numObstacles; i++)
            {
                int pivotX = Random.Range(originAreaX, pivotMaxX); 
                
                for (int x = 0; x < widthObstacle; x++)
                {
                    for (int y = 0; y < heightObstacle; y++)
                    {
                        if (y == 0)
                        {
                            coordenadasObstacle.Add(new Vector3Int(x + pivotX, y + heightStart, 0));
                        }
                        else if (y == 1 && x == 1)
                        {
                            coordenadasObstacle.Add(new Vector3Int(x + pivotX, y + heightStart, 0));
                        }
                    }
                }
            }
            return coordenadasObstacle;

        case MapNum.Area2:
            numObstacles = 3;
            pivotMaxX = endAreaX - widthObstacle;

            for (int i = 0; i < numObstacles; i++)
            {
                int pivotX = Random.Range(originAreaX, pivotMaxX); 
                
                for (int x = 0; x < widthObstacle; x++)
                {
                    for (int y = 0; y < heightObstacle; y++)
                    {
                        if (y == 0)
                        {
                            coordenadasObstacle.Add(new Vector3Int(x + pivotX, y + heightStart, 0));
                        }
                        else if (y == 1 && x == 1)
                        {
                            coordenadasObstacle.Add(new Vector3Int(x + pivotX, y + heightStart, 0));
                        }
                    }
                }
            }
            return coordenadasObstacle;
            
        case MapNum.Area3:
            numObstacles = 5;
            pivotMaxX = endAreaX - widthObstacle;

            for (int i = 0; i < numObstacles; i++)
            {
                int pivotX = Random.Range(originAreaX, pivotMaxX); 
                
                for (int x = 0; x < widthObstacle; x++)
                {
                    for (int y = 0; y < heightObstacle; y++)
                    {
                        if (y == 0)
                        {
                            coordenadasObstacle.Add(new Vector3Int(x + pivotX, y + heightStart, 0));
                        }
                        else if (y == 1 && x == 1)
                        {
                            coordenadasObstacle.Add(new Vector3Int(x + pivotX, y + heightStart, 0));
                        }
                    }
                }
            }
            return coordenadasObstacle;

        case MapNum.Area4:
            numObstacles = 6;
            pivotMaxX = endAreaX - widthObstacle;

            for (int i = 0; i < numObstacles; i++)
            {
                int pivotX = Random.Range(originAreaX, pivotMaxX); 
                
                for (int x = 0; x < widthObstacle; x++)
                {
                    for (int y = 0; y < heightObstacle; y++)
                    {
                        if (y == 0)
                        {
                            coordenadasObstacle.Add(new Vector3Int(x + pivotX, y + heightStart, 0));
                        }
                        else if (y == 1 && x == 1)
                        {
                            coordenadasObstacle.Add(new Vector3Int(x + pivotX, y + heightStart, 0));
                        }
                    }
                }
            }
            return coordenadasObstacle;
            
        case MapNum.Area5:
            numObstacles = 6;
            pivotMaxX = endAreaX - widthObstacle;

            for (int i = 0; i < numObstacles; i++)
            {
                int pivotX = Random.Range(originAreaX, pivotMaxX); 
                
                for (int x = 0; x < widthObstacle; x++)
                {
                    for (int y = 0; y < heightObstacle; y++)
                    {
                        if (y == 0)
                        {
                            coordenadasObstacle.Add(new Vector3Int(x + pivotX, y + heightStart, 0));
                        }
                        else if (y == 1 && x == 1)
                        {
                            coordenadasObstacle.Add(new Vector3Int(x + pivotX, y + heightStart, 0));
                        }
                    }
                }
            }
            return coordenadasObstacle;
        } 
        return coordenadasObstacle;
    }

    public void Render(List<Vector3Int> coordenadas, Tile tile, Tilemap tilemap)
    {
        for (int i = 0; i < coordenadas.Count; i++)
        {
            tilemap.SetTile(coordenadas[i], tile);
        }
    }
}
