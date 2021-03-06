﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    Vector2 position = new Vector2(0f, 0f);
    Rigidbody2D rb;
    Transform Hub;
    public float heightLimit;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Hub = GameObject.FindGameObjectWithTag("Hub").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.x = 0;
        if (mousePosition.y - transform.position.y < 3 && mousePosition.y - transform.position.y > -3)
        {
            mousePosition.y = transform.position.y;
        }
        heightLimit = Hub.position.y + (Hub.localScale.y / 2) - 4;
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    void FixedUpdate()
    {
        if (position.y < heightLimit)
        {
            rb.MovePosition(position);
        }
    }
}
