﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame2 : MonoBehaviour
{

    PlayerControls player;
    songControl2 song;
    public GameObject endGame;
    public Text score;

    void Start()
    {
        player = GameObject.Find("Player Model").GetComponent<PlayerControls>();
        song = GameObject.Find("Background").GetComponent<songControl2>();
    }

    void Update()
    {
        if (song.ended)
        {
            Time.timeScale = 0;
            endGame.SetActive(true);
            score.text = "FINAL SCORE: " + player.points;
        }
    }

    // Use this for initialization
    public void Retry()
    {
        SceneManager.LoadScene(Application.loadedLevel);
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene("main_menu");
    }
}
