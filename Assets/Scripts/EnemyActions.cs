using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActions : MonoBehaviour {

    //public AudioSource explosion;
    public GameObject explodeSprite;

    public GameObject BulletObject;
    Vector3 bulletSpawnPos;

    float startShoot;
    float songLength = 0;
    float intervals;

    public int points = 100;
    PlayerControls player;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "bullet(Clone)")
        {
            player.points += points*player.multiplier;
            Destroy(gameObject);
            Destroy(col.gameObject);
            Instantiate(explodeSprite, transform.position, Quaternion.identity);
        }
    }

    // Use this for initialization
    void Start () {

        player = GameObject.Find("Player Model").GetComponent<PlayerControls>();

        startShoot = Random.Range(2f, 10f);
        if (gameObject.tag == "RandomBomber")
        {
            Debug.Log("Random bomber spawned");
            intervals = Random.Range(2f, 4f);
            InvokeRepeating("FireBullet", startShoot, intervals);
        }
        else
        {
            intervals = Random.Range(6f, 8f);
            InvokeRepeating("FireBullet", startShoot, intervals);
        }
        
    }

    void FireBullet()
    {
        bulletSpawnPos = transform.position - transform.up * 0.1f;
        Instantiate(BulletObject, bulletSpawnPos, Quaternion.identity);
    }

    void FixedUpdate()
    {
        songLength += Time.deltaTime;
        
    }

    void OnEnable()
    {
        
    }
}
