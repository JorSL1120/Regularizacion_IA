using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapController : MonoBehaviour
{
    public Map[] maps;
    private Tilemap map;

    private void Start()
    {
        CreateLevel();
    }

    private void CreateLevel()
    {
        GameObject gridGO = new GameObject("grid");

        Grid grid = gridGO.AddComponent<Grid>();
        grid.cellLayout = GridLayout.CellLayout.Rectangle;
        grid.cellSize = new Vector3(1,1,1);

        GameObject tileMap = new GameObject("Tilemap");
        
        map = tileMap.AddComponent<Tilemap>();
        TilemapRenderer tilemapRenderer = tileMap.AddComponent<TilemapRenderer>();
        tilemapRenderer.sortOrder = TilemapRenderer.SortOrder.TopRight;
        tilemapRenderer.gameObject.AddComponent<TilemapCollider2D>();

        tileMap.transform.SetParent(grid.transform);

        GenerateFloor(map);
    }

    private void GenerateFloor(Tilemap tilemap)
    {
        maps[0].Render(tilemap);

    }

    public void LoadNextLevel()
    {
        map.ClearAllTiles();
        maps[1].Render(map);
    }

    public void LoadPreviousMap()
    {
        map.ClearAllTiles();
        maps[0].Render(map);
    }
}
