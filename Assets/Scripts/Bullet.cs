using UnityEngine;

//This script will handle the bullet adding itself back to the pool
public class Bullet : MonoBehaviour
{
	public int speed = 5;			//How fast the bullet moves
	public float lifeTime = 1;		//How long the bullet lives in seconds
	public int power = 1;			//Power of the bullet
    
    void Update()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        if ((transform.position.x < min.x) || (transform.position.x > max.x) || (transform.position.y < min.y) || (transform.position.y > max.y))
        {
            Destroy(gameObject);
        }

    }

    void OnEnable ()
	{
		GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;	
	}

}