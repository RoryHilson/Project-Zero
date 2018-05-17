﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombSprite : MonoBehaviour {

    void OnEnable()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3( 0, -1.5f, 0);
    }

    // Update is called once per frame
    void Update () {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        if ( (transform.position.x < min.x) || (transform.position.x > max.x) || (transform.position.y < min.y) || (transform.position.y > max.y))
        {
            Destroy(gameObject);
        }

    }
}
