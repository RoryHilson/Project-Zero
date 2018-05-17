using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    float speed = 3.0f;
    public int ammo = 5;
    public int lives = 5;
    public int points = 0;
    public int multiplier = 1;
    public int keyStreak = 0;
    public bool play = true;
    public bool dead = false;
    public GameObject bullet;
    public GameObject explodeSprite;

    private Vector3 objectSpawnPos;
    Vector3 pos;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (points < 0)
        {
            points = 0;
        }
        if (lives <= 0)
        {
            lives = 0;
            dead = true;
        }

        if (lives >=5)
        {
            lives = 5;
        }

        if (!dead)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                pos = transform.position;
                pos.x -= speed * Time.deltaTime;
                pos.x = Mathf.Clamp(pos.x, -5f, 5f);
                transform.position = pos;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                pos = transform.position;
                pos.x += speed * Time.deltaTime;
                pos.x = Mathf.Clamp(pos.x, -5f, 5f);
                transform.position = pos;
            }

            objectSpawnPos = transform.position + transform.up * 0.2f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (ammo != 0)
                {
                    Instantiate(bullet, objectSpawnPos, Quaternion.identity);
                    ammo--;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "bombSprite(Clone)")
        {
            lives--;
            Instantiate(explodeSprite, transform.position, Quaternion.identity);
            points -= 50;
            Destroy(col.gameObject);
        }
    }
}
