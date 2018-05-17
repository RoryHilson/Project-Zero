using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songControl3 : MonoBehaviour {
    //around 2.1 seconds                        1                                 2                                                 15
    List<float> noteSelect = new List<float>() {8.6f,10.6f,13.5f,15.8f,18.5f,20.5f,23,25.8f,28.5f,33.6f,36.5f,40,43.7f,48.5f,53.7f,58.5f,63.5f,
                                                67,71.9f,75.8f,78.7f,81.8f,87,91,93.6f,98,101.5f,106.5f,110.5f,115.6f,121,126,132,138,142,146.6f,152,157,
                                                161.6f,166,171.2f,173.6f,176.5f,181.5f,186.5f,192,199.6f,202.1f,207,213.5f,218,223.6f,228.5f,
                                                233.5f,238.5f,243.5f,248.5f,253.5f,258.5f,263.5f,268.5f,273.5f,278.5f
                                                };
    //each sequence is 8 notes long             53                     |                             |                                                  37 
    public AudioSource theSong;

    public int songMaker = 0;

    public Transform note1;
    public Transform note2;
    public Transform note3;

    public float songlength = 0;

    public KeyCode keyD;
    public KeyCode keyF;
    public KeyCode keyG;

    public static string destroyD = "n";
    public static string destroyF = "n";
    public static string destroyG = "n";

    public bool playing;
    public bool started;
    public bool ended;

    void FixedUpdate()
    {
        songlength += Time.deltaTime;
        if ((songlength >= 0.4) && (songlength <= 0.5125))
        {
            started = true;
            theSong.Play();
            playing = true;
        }
        if (songlength >= 285)
        {
            ended = true;
            started = false;
            theSong.Stop();
            playing = false;
        }
        if ((songlength>=noteSelect[songMaker]) && (songlength <= noteSelect[songMaker] + .125) && songMaker <= noteSelect.Count)
        { //chorus                                                                                                              +8 + 8 +8
            if (songMaker == 0 || songMaker == 4 || songMaker == 8 || songMaker == 11 || songMaker == 14 || songMaker == 17 || songMaker == 19 || songMaker == 23 || songMaker == 24 || songMaker == 27 || songMaker == 29 || songMaker == 34 || songMaker == 38 || songMaker == 40 || songMaker == 44 || songMaker == 47 || songMaker == 50 || songMaker == 52 || songMaker == 54 || songMaker == 56 || songMaker == 59)
            {
                Instantiate(note1, note1.position, note1.rotation);
            }
            if (songMaker == 1 || songMaker == 3 || songMaker == 5 || songMaker == 7 || songMaker == 10 || songMaker == 13 || songMaker == 16 || songMaker == 21 || songMaker == 25 || songMaker == 30 || songMaker == 31 || songMaker == 36 || songMaker == 37 || songMaker == 39 || songMaker == 42 || songMaker == 45 || songMaker == 46 || songMaker == 51 || songMaker == 55 || songMaker == 57 || songMaker == 60 || songMaker == 62)
            {
                Instantiate(note2, note2.position, note2.rotation);
            }
            if (songMaker == 2 || songMaker == 6 || songMaker == 9 || songMaker == 12 || songMaker == 15 || songMaker == 18 || songMaker == 20 || songMaker == 22 || songMaker == 26 || songMaker == 28 || songMaker == 32 || songMaker == 33 || songMaker == 35 || songMaker == 41 || songMaker == 43 || songMaker == 48 || songMaker == 49 || songMaker == 53 || songMaker == 58 || songMaker == 61)
            {
                Instantiate(note3, note3.position, note3.rotation);

            }
            songMaker += 1;
        }

    }
    
    void OnTriggerStay2D(Collider2D other)
    {
            //Debug.Log(other.gameObject.name);
            if ((Input.GetKeyDown(keyD)) && (other.gameObject.name == "bombD(Clone)"))
            {
                destroyD = "y";
            }
            if ((Input.GetKeyDown(keyF)) && (other.gameObject.name == "bombF(Clone)"))
            {
                destroyF = "y";
            }
            if ((Input.GetKeyDown(keyG)) && (other.gameObject.name == "bombG(Clone)"))
            {
                destroyG = "y";
            }
    }
    
    // Use this for initialization
    void Start () {
}
	
	// Update is called once per frame
	void Update () {
		
	}
}
