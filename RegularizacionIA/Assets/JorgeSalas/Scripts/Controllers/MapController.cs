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

        GenerateFloor(map);
    }

    private void GenerateFloor(Tilemap tilemap)
    {
        Map map = new Map("Floor", mapOrigin[1], mapSizes[1], tilemap, FloorType.Floor);
        List<Vector3Int> coordenadas = map.generateCoordinates();

        map.Render(coordenadas, tiles[0], tilemap);
    }
}
