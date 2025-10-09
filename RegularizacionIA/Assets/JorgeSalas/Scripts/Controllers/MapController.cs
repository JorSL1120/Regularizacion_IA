using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapController : MonoBehaviour
{
    public List<Vector2Int> mapSizes;
    public List<Vector2Int> mapOrigin;
    public List<Tile> tiles;

    private void Start()
    {
        GameObject grid = new GameObject();
        grid.name = "Grid";

        grid.AddComponent<Grid>();
        Grid isometricGrid = grid.GetComponent<Grid>();
        isometricGrid.cellLayout = GridLayout.CellLayout.Rectangle;
        isometricGrid.cellSize = new Vector3(1, 0.5f, 1);

        GameObject tilemap = new GameObject();
        tilemap.name = "Tilemap";

        tilemap.AddComponent<Tilemap>();
        tilemap.AddComponent<TilemapRenderer>();
        TilemapRenderer tilemapRenderer = tilemap.GetComponent<TilemapRenderer>();
        tilemapRenderer.sortOrder = TilemapRenderer.SortOrder.TopRight;

        tilemap.transform.parent = grid.transform;

        Tilemap map = tilemap.GetComponent<Tilemap>();

        GenerateArea1(map);
        GenerateArea2(map);
        //GenerateArea3(map);
        //GenerateArea4(map);
        //GenerateArea5(map);
    }

    private void GenerateArea1(Tilemap tilemap)
    {
        Map map = new Map("Area1", mapOrigin[0], mapSizes[0], tilemap, MapNum.Area1);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[0], tilemap);
        List<Vector3Int> coordenadasPlat = map.GeneratePlatforms();
        map.Render(coordenadasPlat, tiles[0], tilemap);
    }

    private void GenerateArea2(Tilemap tilemap)
    {
        Map map = new Map("Area2", mapOrigin[1], mapSizes[1], tilemap, MapNum.Area2);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[1], tilemap);
        List<Vector3Int> coordenadasPlat = map.GeneratePlatforms();
        map.Render(coordenadasPlat, tiles[1], tilemap);
    }

    /*private void GenerateArea3(Tilemap tilemap)
    {
        Map map = new Map("Area3", mapOrigin[2], mapSizes[2], tilemap, MapNum.Area3);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[2], tilemap);
        List<Vector3Int> coordenadasPlatforms = map.GeneratePlatforms();
        map.Render(coordenadasPlatforms, tiles[2], tilemap);
    }

    private void GenerateArea4(Tilemap tilemap)
    {
        Map map = new Map("Area4", mapOrigin[3], mapSizes[3], tilemap, MapNum.Area4);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[3], tilemap);
        List<Vector3Int> coordenadasPlatforms = map.GeneratePlatforms();
        map.Render(coordenadasPlatforms, tiles[3], tilemap);
    }

    private void GenerateArea5(Tilemap tilemap)
    {
        Map map = new Map("Area5", mapOrigin[4], mapSizes[4], tilemap, MapNum.Area5);
        List<Vector3Int> coordenadas = map.GenerateCoordinates();
        map.Render(coordenadas, tiles[4], tilemap);
        List<Vector3Int> coordenadasPlatforms = map.GeneratePlatforms();
        map.Render(coordenadasPlatforms, tiles[4], tilemap);
    }*/
}
