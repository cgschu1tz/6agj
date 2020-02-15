using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Universe : MonoBehaviour
{
    public Tile[,] BelowGround { get; private set; }

    void Awake()
    {
        Debug.Log("Hello, universe.");
    }
}
