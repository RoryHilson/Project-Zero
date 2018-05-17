using UnityEngine;

//This script controls the scrolling of the background
public class Background : MonoBehaviour
{
	public float speed = 0.25f;			//Speed of the scrolling
	
	void Update ()
	{
		float y = Mathf.Repeat (Time.time * speed, 1);
		Vector2 offset = new Vector2 (0, y);
		GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
	}
}