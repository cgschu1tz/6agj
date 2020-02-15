using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Universe : MonoBehaviour
{
    public Tile[,] BelowGround { get; private set; }

    void Awake()
    {
        Debug.Log("Hello, universe.");
        var map = GameObject.FindGameObjectWithTag("BelowGround").GetComponent<Tilemap>();
        Debug.Log(map.color);
    }
}
