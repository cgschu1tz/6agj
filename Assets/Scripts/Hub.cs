using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Scripts
{
    public class Hub : MonoBehaviour
    {
        public Tilemap belowGround, aboveGround;
        public TileBase dirt, iron, water;
        public TileBase[] grass;
        public List<LineRenderer> roots;

        void Awake()
        {
            Debug.Log("Hello, world.");
        }
    }
}