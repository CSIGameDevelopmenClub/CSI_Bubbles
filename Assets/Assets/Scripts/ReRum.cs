using UnityEngine;
using System.Collections;

public class RedRandom_Movement : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
		delay(3.0f);
		Debug.Log ("Delay finish");
		randMovi ();
		Debug.Log ("MovementPerformed");
	}
	
	
	// Update is called once per frame
	void Update () {
	}
	
	IEnumerator delay(float sec)
	{
		yield return new WaitForSeconds (sec);
	}
	
	void randMovi ()
	{
		float randX = Random.Range (-10.0f, 10.0f);
		float randY = Random.Range (-10.0f, 10.0f);
		if (randX<=0)
		{
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range (-100.0f,-30.0f),0));
		}
		else
		{
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range (30.0f,100.0f),0));
		}
		if (randY<=0)
		{
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,Random.Range (-100.0f,-30.0f)));
		}
		else
		{
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,Random.Range (30.0f,100.0f)));
		}
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}
