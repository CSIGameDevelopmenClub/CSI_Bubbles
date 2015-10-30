using UnityEngine;
using System.Collections;

public class WallCollision : MonoBehaviour {
	float valToChange;
	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {
		//Debug.Log ("WORK");

	}

	void OnTriggerEnter2D(Collider2D other)
	{

		Debug.Log ("Collided!");
		if (gameObject.tag == "West" || gameObject.tag == "East") {
			other.GetComponent<Rigidbody2D>().velocity = new 
				Vector2(other.GetComponent<Rigidbody2D>().velocity.x*-1,
				        other.GetComponent<Rigidbody2D>().velocity.y);
		}
	}
}
