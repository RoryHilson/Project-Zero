using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    Vector3 spawnPos;
    Vector3 currentPos;

    // Use this for initialization
    void Start () {
        spawnPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        if (spawnPos.x < 0)
        {

            transform.Translate(Vector2.right * 1 * Time.deltaTime);
            currentPos = transform.position;
            if (gameObject.tag == "Wave")
            {
                if (currentPos.x >= 10)
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                if (currentPos.x > max.x+1)
                {
                    Destroy(gameObject);
                }
            }
        }
        if (spawnPos.x > 0)
        {
            transform.Translate(Vector2.left * 1 * Time.deltaTime);
            currentPos = transform.position;
            if (gameObject.tag == "Wave")
            {
                if (currentPos.x <= -8)
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                if (currentPos.x < min.x-1)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
