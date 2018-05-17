using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songControl2 : MonoBehaviour {
    //around 2.1 seconds                        1                                 2
    List<float> noteSelect = new List<float>() {5,7.3f,7.5f,7.7f,8.2f,8.4f,8.6f,8.8f,9.5f,9.8f,10.1f,10.4f,10.7f,11,
                                                11.2f,11.3f,11.4f,11.7f,12,12.3f,12.6f,12.9f,13.2f,13.3f,13.4f,
                                                13.6f,13.9f,14.2f,14.5f,14.8f,15.1f,15.4f,15.5f,15.6f,15.9f,16.2f,
                                                16.5f,16.8f,17.1f,17.4f,17.5f,17.6f,17.8f,18.1f,18.4f,18.7f,19,19.3f,
                                                19.5f,19.6f,19.7f,20,20.3f,20.6f,20.9f,21.2f,21.7f,22.3f,22.6f,22.9f,23.2f,23.4f,23.6f,
                                                23.9f,24.2f,24.5f,24.8f,25.1f,25.4f,25.7f,26,26.3f,26.5f,26.7f,
                                                28.5f,28.7f,28.8f,30.5f,30.7f,30.8f,32.6f,32.8f,32.9f,34.6f,34.8f,34.9f,37,37.2f,37.3f,
                                                39.1f,39.3f,39.4f,41.1f,41.3f,41.4f,43.1f,43.3f,43.4f,45.7f,45.9f,46,46.6f,46.8f,46.9f,
                                                47.2f,47.3f,47.4f,47.6f,49.5f,49.7f,49.8f
                                                };
    //each sequence is 8 notes long                                                               |                     
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
        if ((songlength >= 2.4) && (songlength <= 2.5125))
        {
            started = true;
            theSong.Play();
            playing = true;
        }
        if (songlength >= 56)
        {
            ended = true;
            started = false;
            theSong.Stop();
            playing = false;
        }
        if ((songlength>=noteSelect[songMaker]) && (songlength <= noteSelect[songMaker] + .125) && songMaker <= noteSelect.Count)
        { //chorus                                                                                                              +8 + 8 +8
            if (songMaker == 0 || songMaker == 4 || songMaker == 8 || songMaker == 11 || songMaker == 14 || songMaker == 15 || songMaker == 16 || songMaker == 19 || songMaker == 27 || songMaker == 30 || songMaker == 31 || songMaker == 32 || songMaker == 33 || songMaker == 36 || songMaker == 44 || songMaker == 47 || songMaker == 48 || songMaker == 49 || songMaker == 50 || songMaker == 53 || songMaker == 56 || songMaker == 57 || songMaker == 60 || songMaker == 63 || songMaker == 65 || songMaker == 68 || songMaker == 71 || songMaker == 73 ||
                songMaker == 74 || songMaker == 75 || songMaker == 76 || songMaker == 77 || songMaker == 78 || songMaker == 79 || songMaker == 86 || songMaker == 87 || songMaker == 88 || songMaker == 89 || songMaker == 90 || songMaker == 91 || songMaker == 98 || songMaker == 99 || songMaker == 100 || songMaker == 101 || songMaker == 102 || songMaker == 103 || songMaker == 104 || songMaker == 105 || songMaker == 106 || songMaker == 107 || songMaker == 108 ||
                songMaker == 109 || songMaker == 110 || songMaker == 111)
            {
                Instantiate(note1, note1.position, note1.rotation);
            }
            if (songMaker == 1 || songMaker == 3 || songMaker == 5 || songMaker == 7 || songMaker == 9 || songMaker == 12 || songMaker == 17 || songMaker == 20 || songMaker == 26 || songMaker == 29 || songMaker == 34 || songMaker == 37 || songMaker == 43 || songMaker == 46 || songMaker == 51 || songMaker == 54 || songMaker == 58 || songMaker == 61 || songMaker == 64 || songMaker == 66 || songMaker == 69 || songMaker == 72 || songMaker == 108 ||
                songMaker == 74 || songMaker == 75 || songMaker == 76 || songMaker == 77 || songMaker == 78 || songMaker == 79 || songMaker == 80 || songMaker == 81 || songMaker == 82 || songMaker == 83 || songMaker == 84 || songMaker == 85 || songMaker == 86 || songMaker == 87 || songMaker == 88 || songMaker == 89 || songMaker == 90 || songMaker == 91 || songMaker == 92 || songMaker == 93 || songMaker == 94 || songMaker == 95 || songMaker == 96 || songMaker == 97 ||
                songMaker == 109 || songMaker == 110 || songMaker == 111)
            {
                Instantiate(note2, note2.position, note2.rotation);
            }
            if (songMaker == 0 || songMaker == 2 || songMaker == 6 || songMaker == 10 || songMaker == 13 || songMaker == 18 || songMaker == 21 || songMaker == 22 || songMaker == 23 || songMaker == 24 || songMaker == 25 || songMaker == 28 || songMaker == 35 || songMaker == 38 || songMaker == 39 || songMaker == 40 || songMaker == 41 || songMaker == 42 || songMaker == 45 || songMaker == 52 || songMaker == 55 || songMaker == 56 || songMaker == 59 || songMaker == 62 || songMaker == 67 || songMaker == 70 || songMaker == 73 ||
                songMaker == 80 || songMaker == 81 || songMaker == 82 || songMaker == 83 || songMaker == 84 || songMaker == 85 || songMaker == 92 || songMaker == 93 || songMaker == 94 || songMaker == 95 || songMaker == 96 || songMaker == 97 || songMaker == 98 || songMaker == 99 || songMaker == 100 || songMaker == 101 || songMaker == 102 || songMaker == 103 || songMaker == 104 || songMaker == 105 || songMaker == 106 || songMaker == 107)
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
