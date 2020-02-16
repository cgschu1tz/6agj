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

        public float creationRate, creationDisplacement, rotationDisplacement;
        public Vector3 firstPoint;

        void Awake()
        {
            _creationTimer = 0;
            _rotationTimer = 0;

            _lineRenderer = GetComponent<LineRenderer>();
            _lineRenderer.positionCount = 1;
            _lineRenderer.SetPositions(new[] { firstPoint });
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
                }
            }
            else
            {
                _creationTimer = 0;
            }
        }
    }
}
