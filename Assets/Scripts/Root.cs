using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Scripts
{
    public class Root : MonoBehaviour
    {
        private float _rotationTimer, _creationTimer;
        private LineRenderer _lineRenderer;
        private Vector3 _direction = Vector3.down;
        private EdgeCollider2D _edgeCollider;
        private List<Vector2> _edgeColliderPoints = new List<Vector2>();

        public float creationRate, creationDisplacement, rotationDisplacement;
        public Vector3 firstPoint;

        void Awake()
        {
            _creationTimer = 0;
            _rotationTimer = 0;

            _lineRenderer = GetComponent<LineRenderer>();
            _lineRenderer.positionCount = 1;
            _lineRenderer.SetPositions(new[] { firstPoint });

            _edgeCollider = GetComponent<EdgeCollider2D>();
            _edgeCollider.points = new[] { new Vector2(firstPoint.x, firstPoint.y) };
        }

        void Update()
        {
            var latestPoint = _lineRenderer.GetPosition(_lineRenderer.positionCount - 1);

            if (Input.GetKey(KeyCode.W))
            {
                _creationTimer += Time.deltaTime;

                if (_creationTimer >= creationRate)
                {
                    _creationTimer -= creationRate;

                    // Adjust heading.
                    if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
                    {
                        _direction = Quaternion.Euler(0, 0, -rotationDisplacement) * _direction;
                    }
                    else if (!Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
                    {
                        _direction = Quaternion.Euler(0, 0, rotationDisplacement) * _direction;
                    }

                    // Move in that direction.
                    var newPoint = creationDisplacement * _direction + latestPoint;
                    _lineRenderer.SetPosition(_lineRenderer.positionCount++, newPoint);
                    _edgeColliderPoints.Add(new Vector2(newPoint.x, newPoint.y));
                }
            }
            else
            {
                _creationTimer = 0;
            }

            _edgeCollider.points = _edgeColliderPoints.ToArray();
        }

        void OnTriggerEnter2D(Collision2D collision)
        {
            Debug.Log("Buy Full version Winrar" + collision.gameObject.name);
        }
    }
}
