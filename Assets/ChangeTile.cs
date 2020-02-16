using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ChangeTile : MonoBehaviour
{
    public Tile tile;
    public Tilemap tilemap;
    private Vector3Int pos;

    // Start is called before the first frame update
    void Start()
    {
        pos.x = 0;
        pos.y = 0;
        pos.z = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
        tilemap.SetTile(pos, tile);
    }
}
