using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScript : MonoBehaviour {

    PlayerControls player;
    public GameObject retryScreen;

    void Start()
    {
        player = GameObject.Find("Player Model").GetComponent<PlayerControls>();
    }

    void Update()
    {
        if (player.dead)
        {
            Time.timeScale = 0;
            retryScreen.SetActive(true);
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
