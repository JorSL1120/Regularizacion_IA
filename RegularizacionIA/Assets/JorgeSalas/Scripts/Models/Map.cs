using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[System.Serializable]
public class Map
{
    [SerializeField] private string name;
    [SerializeField] private bool isVisible;
    public MapInfo[] mapInfo;


    public Map(string name)//, Vector2Int originCoordinates, Vector2Int size)
    {
        this.name = name;
        //this.originCoordinates = originCoordinates;
        //this.size = size;
    }

    public string Name
    {
        get
        {
            return name;
        }
    }

    //public List<Vector2Int> OriginCoordinates
    //{
    //    get
    //    {
    //        return mapInfo.originCoordinates;
    //    }
    //}

    //public List<Vector2Int> Size
    //{
    //    get
    //    {
    //        return mapInfo.size;
    //    }
    //}

    internal List<Vector3Int> GenerateCoordinates()
    {
        List<Vector3Int> positions = new List<Vector3Int>();


        for (int indexOrigins = 0; indexOrigins < mapInfo.Length;indexOrigins++)
        {
            for (int i = 0; i < mapInfo[indexOrigins].size.x; i++)
            {
                for (int j = 0; j < mapInfo[indexOrigins].size.y; j++)
                {
                    positions.Add(new Vector3Int(mapInfo[indexOrigins].originCoordinates.x + i, mapInfo[indexOrigins].originCoordinates.y + j, 0));
                }

            }
        }
        return positions;
    }

    internal void Render(Tilemap tilemap)
    {
        for (int indexOrigins = 0; indexOrigins < mapInfo.Length; indexOrigins++)
        {
            for (int i = 0; i < mapInfo[indexOrigins].size.x; i++)
            {
                for (int j = 0; j < mapInfo[indexOrigins].size.y; j++)
                {
                    //positions.Add(new Vector3Int(mapInfo[indexOrigins].originCoordinates.x + i, mapInfo[indexOrigins].originCoordinates.y + j, 0));
                    tilemap.SetTile(new Vector3Int(mapInfo[indexOrigins].originCoordinates.x + i, mapInfo[indexOrigins].originCoordinates.y + j, 0), mapInfo[indexOrigins].tiles);
                }

            }
        }
    }

    internal void Hide(Tilemap tilemap)
    {
        tilemap.ClearAllTiles();
    }
}

[System.Serializable]
public class MapInfo
{
    public Vector2Int originCoordinates;
    public Vector2Int size;
    public Tile tiles;
}


