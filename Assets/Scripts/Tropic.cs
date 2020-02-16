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
        private float _timer;
        private LineRenderer _lineRenderer;

        public float creationRate;
        public float proportionalGrowth;
        public float minDistanceToGrow;
        public Vector3 target;

        void Awake()
        {
            _timer = 0;
        }

        void Update()
        {
            var latestPoint = _lineRenderer.GetPosition(_lineRenderer.positionCount - 1);

            if (Math.Abs(
                Vector3.Magnitude(latestPoint - target)
                ) >= minDistanceToGrow)
            {
                _timer += Time.deltaTime;

                if (_timer >= creationRate)
                {
                    _timer -= creationRate;

                    // Move towards the target.
                }
            }
            else
            {
                _timer = 0;
            }

            _lineRenderer.positionCount++;
            _lineRenderer.SetPosition(_lineRenderer.positionCount++, newPoint);
        }
    }
}
