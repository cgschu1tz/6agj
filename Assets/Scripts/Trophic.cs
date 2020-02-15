using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Scripts
{
    public class Trophic : MonoBehaviour
    {
        public List<Vector3> points;
        public Tilemap belowGround;

        void Awake()
        {
            enabled = false;
            points.Add(new Vector3(0, 0, 1));
        }

        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                var lr = GetComponent<LineRenderer>();
                var pt = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                pt.z = 0;

                points.Add(pt);
                lr.positionCount = points.Count;
                lr.SetPositions(points.ToArray());
            }
        }
    }
}
