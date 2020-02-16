using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GenerateMap : MonoBehaviour
{
    public Grid grid;
    public Tilemap tilemap;
    public Tile dirtTile;
    public Tile ironTile;
    public Tile nitrogenTile;
    public Tile waterTile;

    // Start is called before the first frame update
    void Start()
    {
        int randomInt = 0;
        Tile tileToAdd;

        for (int i = tilemap.cellBounds.xMin; i < tilemap.cellBounds.xMax; i++)
        {
            for (int j = tilemap.cellBounds.yMin; j < tilemap.cellBounds.yMax; j++)
            {
                randomInt = Random.Range(0, 1000);

                if (randomInt < 5)
                    tileToAdd = ironTile;
                else if (randomInt < 10)
                    tileToAdd = nitrogenTile;
                else if (randomInt < 60)
                    tileToAdd = waterTile;
                else
                    tileToAdd = dirtTile;

                tilemap.SetTile(new Vector3Int(i, j, 0), tileToAdd);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ((Camera.main.transform.position.y - 10) < tilemap.cellBounds.yMin)
        {
            Debug.Log(tilemap.cellBounds.yMin);
            AddNextLine();
        }
    }

    private void AddNextLine()
    {
        Tile tileToAdd;
        int randomInt = 0;
        int newMin = tilemap.cellBounds.yMin - 1;

        for (int i = tilemap.cellBounds.xMin; i < tilemap.cellBounds.xMax; i++)
        {
            randomInt = Random.Range(0, 1000);

            if (randomInt < 5)
                tileToAdd = ironTile;
            else if (randomInt < 10)
                tileToAdd = nitrogenTile;
            else if (randomInt < 60)
                tileToAdd = waterTile;
            else
                tileToAdd = dirtTile;

            tilemap.SetTile(new Vector3Int(i, newMin, 0), tileToAdd);
        }
    }
}
