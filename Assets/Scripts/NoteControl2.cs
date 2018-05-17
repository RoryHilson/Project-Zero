using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteControl2 : MonoBehaviour {

    public Transform burst;

    public int points = 40;
    public int keyStreak = 0;
    PlayerControls player;

    bool streakChange = false;

    // Use this for initialization
    void Start () {
        
        player = GameObject.Find("Player Model").GetComponent<PlayerControls>();

        if (gameObject.name == "bombD(Clone)")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -2, 0);
        }
        if (gameObject.name == "bombF(Clone)")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -2, 0);
        }
        if (gameObject.name == "bombG(Clone)")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -2, 0);
        }
    }
	
	// Update is called once per frame
	void Update () {
	    if (( songControl2.destroyD == "y") && (gameObject.name == "bombD(Clone)") && (transform.position.y<=-1.3))
        {
            //Instantiate(burst, transform.position, burst.rotation);
            songControl2.destroyD = "n";
            addToStreak();
            Destroy(gameObject);
            player.points += points * player.multiplier;

        }
        if ((songControl2.destroyF == "y") && (gameObject.name == "bombF(Clone)") && (transform.position.y <= -1.3))
        {
            //Instantiate(burst, transform.position, burst.rotation);
            songControl2.destroyF = "n";
            Destroy(gameObject);
            addToStreak();
            player.points += points * player.multiplier;
        }
        if ((songControl2.destroyG == "y") && (gameObject.name == "bombG(Clone)") && (transform.position.y <= -1.3))
        {
            //Instantiate(burst, transform.position, burst.rotation);
            songControl2.destroyG = "n";
            Destroy(gameObject);
            addToStreak();
            player.points += points * player.multiplier;
        }
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        if ((transform.position.x < min.x) || (transform.position.x > max.x) || (transform.position.y < min.y) || (transform.position.y > max.y))
        {
            Destroy(gameObject);
        }
        
        if (streakChange)
        {
            if ((player.keyStreak % 5 == 0) && (player.keyStreak >= 5))
            {
                player.ammo++;
            }
            if ((player.keyStreak % 15 == 0) && (player.keyStreak >= 15))
            {
                player.multiplier += 1;
                player.lives++;
            }
            streakChange = false;
        }
    }

    void addToStreak()
    {
        player.keyStreak++;
        streakChange = true;
        Debug.Log(player.keyStreak);
    }

    void OnTriggerEnter2D(Collider2D dZone)
    {

        if (dZone.tag == "Destroy Zone")
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);
        }
    }

    void OnTriggerExit2D(Collider2D dZone)
    {

        if (dZone.tag == "Destroy Zone")
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
            player.keyStreak = 0;
            streakChange = true;
            player.multiplier = 1;
        }
    }
}
