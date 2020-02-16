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
        private float _timer = 0;
        private List<Vector3> _points = new List<Vector3>();
        private int _mouseBtn = 0;

        void Awake()
        {
            _points.Add(new Vector3(0, 0, 0));
        }

        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                _timer += Time.deltaTime;

                var lr = GetComponent<LineRenderer>();
                var pt = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                pt.z = 0;

                _points.Add(pt);
                lr.positionCount = _points.Count;
                lr.SetPositions(_points.ToArray());
            }
            else
            {
                _timer = 0;
            }
        }
    }
}
