using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayPause : MonoBehaviour
{

    PlayerControls player;
    public GameObject pauseMenu;
    songControl song;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player Model").GetComponent<PlayerControls>();
        song = GameObject.Find("Background").GetComponent<songControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            player.play = !player.play;
        }
        if (player.play)
        {
            if (!song.playing && song.started)
            {
                song.theSong.Play();
                song.playing = true;
            }
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
        else if (!player.play)
        {
            if (song.playing)
            {
                song.theSong.Pause();
                song.playing = false;
            }
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
    }

    public void Resume()
    {
        player.play = true;
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene("main_menu");
    }

    public void Retry()
    {
        SceneManager.LoadScene(Application.loadedLevel);
    }
}
