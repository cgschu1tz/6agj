using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class RootFollow : MonoBehaviour
    {
        Vector3 rootPosition;
        public float moveSpeed = 0.1f;
        Vector2 position = new Vector2(0f, 0f);
        Rigidbody2D rb;
        Transform Hub;
        Hub root;
        public float heightLimit;
        LineRenderer lr;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            Hub = GameObject.FindGameObjectWithTag("Hub").GetComponent<Transform>();
            root = GameObject.FindGameObjectWithTag("Hub").GetComponent<Hub>();
        }

        // Update is called once per frame
        void Update()
        {
            lr = root.followMe.GetComponent<LineRenderer>();
            if (lr != null)
            {
                rootPosition = lr.GetPosition(lr.positionCount - 1);
                rootPosition.x = 0;
                if (rootPosition.y - transform.position.y < 3 && rootPosition.y - transform.position.y > -3)
                {
                    rootPosition.y = transform.position.y;
                }
                heightLimit = Hub.position.y + (Hub.localScale.y / 2) - 4;
                position = Vector2.Lerp(transform.position, rootPosition, moveSpeed);
            }
        }

        void FixedUpdate()
        {
            if (position.y < heightLimit)
            {
                rb.MovePosition(position);
            }
        }
    }
}