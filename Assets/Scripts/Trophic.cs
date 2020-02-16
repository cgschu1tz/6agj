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
        private float _timer = 0f;
        private List<Vector3> _points3D = new List<Vector3>();
        private List<Vector2> _points2D = new List<Vector2>();
        private int _mouseBtn = 0;
        private LineRenderer _lineRenderer;
        private EdgeCollider2D _edgeCollider;

        public float creationRate;
        public float proportionalGrowth;
        public float minDistanceToGrow;

        void Awake()
        {
            _points3D.Add(new Vector3(0, 0, 0));
            _points2D.Add(new Vector2(0, 0));
            _lineRenderer = GetComponent<LineRenderer>();
            _edgeCollider = GetComponent<EdgeCollider2D>();
        }

        void Update()
        {
            if (Input.GetMouseButton(_mouseBtn))
            {
                _timer += Time.deltaTime;

                if (_timer > creationRate)
                {
                    _timer -= creationRate;

                    var clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    clickPosition.z = 0;

                    var remainingDisplacement = clickPosition - _points3D[_points3D.Count - 1];
                    if (Vector3.Magnitude(remainingDisplacement) > minDistanceToGrow)
                    {
                        var newPoint = _points3D[_points3D.Count - 1] + (proportionalGrowth * remainingDisplacement);

                        _points3D.Add(newPoint);
                        _points2D.Add(newPoint);
                    }
                }
            }
            else
            {
                _timer = 0;
            }

            _lineRenderer.positionCount = _points3D.Count;
            _lineRenderer.SetPositions(_points3D.ToArray());

            _edgeCollider.points = _points2D.ToArray();
        }

        void OnCollisionStay(Collision collision)
        {
            Debug.Log(collision.gameObject);
        }
    }
}
