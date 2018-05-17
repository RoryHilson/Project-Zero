using UnityEngine;
using System.Collections;

//This script manages each wave of enemies
public class WaveScript2 : MonoBehaviour
{
    public GameObject wave1;
    public GameObject wave2;
    public GameObject wave3;
    public GameObject bomber;

    GameObject spawn;
    Vector3 spawnPos;

    float songLength = 0;
    float spawnX, spawnY;
    float spawnLeft = -8f;
    float spawnRight = 8f;
    int intervals;

    int randomWave;
    int randomPos;

    void Start()
    {
        intervals = Random.Range(6, 8);
        //InvokeRepeating("SpawnEnemy", 5, intervals);
        InvokeRepeating("SpawnWave", 2, 14);
        InvokeRepeating("Spawn", 5, 2f);
    }

    void Spawn()
    {
        //Instantiate(bomber, new Vector3(-1*spawnX, -1*spawnY, 0), Quaternion.identity);
        Instantiate(bomber, new Vector3(spawnX, spawnY, 0), Quaternion.identity);
    }

    void SpawnWave()
    {
        chooseWave();
        Instantiate(spawn, spawnPos, Quaternion.identity);
    }

    void chooseWave()
    {

        randomPos = Random.Range(0, 2);

        randomWave = Random.Range(0, 3);
        if (randomWave == 0)
        {
            spawn = wave1;
            spawnY = Random.Range(-0.72f, 1.76f);
        }
        else if (randomWave == 1)
        {
            spawn = wave2;
            spawnY = Random.Range(0.76f, 2.77f);
        }
        else
        {
            spawn = wave3;
            spawnY = Random.Range(-0.72f, 1.42f);
        }
        if (randomPos == 0)
        {
            spawnPos = new Vector3(spawnLeft, spawnY, 0);
        }
        else
        {
            spawnPos = new Vector3(spawnRight, spawnY, 0);
        }
    }

    void FixedUpdate()
    {
        songLength += Time.deltaTime;
        spawnX = Random.Range(-8f, 8f);
        spawnY = Random.Range(-1.3f, 1.5f);



        if (spawnX > -5 && spawnX < 0)
        {
            spawnX = -8;
        }
        if (spawnX > 0 && spawnX < 6)
        {
            spawnX = 8;
        }

    }
}
