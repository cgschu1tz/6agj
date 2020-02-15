using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Jam
{
    public class World : MonoBehaviour
    {
        public Tilemap belowGround, aboveGround;
        public TileBase dirt, iron, water;
        public TileBase[] grass;

        void Awake()
        {
            Debug.Log("Hello, world.");
        }
    }
}