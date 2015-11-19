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


		if (gameObject.tag == "West" || gameObject.tag == "East") {
			other.GetComponent<Rigidbody2D>().velocity = new 
				Vector2(other.GetComponent<Rigidbody2D>().velocity.x*-1,
				        other.GetComponent<Rigidbody2D>().velocity.y);
		}
		if (gameObject.tag == "North" || gameObject.tag == "South") {
			other.GetComponent<Rigidbody2D>().velocity = new 
				Vector2(other.GetComponent<Rigidbody2D>().velocity.x,
				        other.GetComponent<Rigidbody2D>().velocity.y*-1);
		}
	}
}
