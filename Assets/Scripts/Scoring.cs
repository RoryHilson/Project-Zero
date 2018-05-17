using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

    PlayerControls player;
    public Text score;
    public Text lives;
    public Text ammo;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player Model").GetComponent<PlayerControls>();
    }
	
	// Update is called once per frame
	void Update () {
        score.text = "Score: " + player.points;
        lives.text = "Lives: x" + player.lives;
        ammo.text = "Ammo: x" + player.ammo;
	}
}
