﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
    public float speed;             
    private Rigidbody2D rb2d;       


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        
        Vector2 movement = new Vector2(moveHorizontal, 0f);

        rb2d.AddForce(movement * speed);
    }
}
