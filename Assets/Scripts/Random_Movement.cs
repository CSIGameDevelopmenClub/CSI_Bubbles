using UnityEngine;
using System.Collections;

public class Random_Movement : MonoBehaviour {

	public static float xMov, yMov, deciderX, deciderY;
	// Use this for initialization
	void Start () {
	deciderX = Random.Range (-1.0f, 1.0f);
		deciderY = Random.Range (-1.0f, 1.0f);
			if (deciderX < 0.0f) 
			xMov = Random.Range (-70.0f, -30.0f);
		    else 
			xMov = Random.Range (30.0f, 70.0f);
		
//		    if (deciderY < 0.0f) 
//			yMov = Random.Range (-7.0f, -3.0f);
//		else
//			yMov = Random.Range (3.0f, 7.0f);

			
	}

	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (xMov, yMov) * Time.deltaTime;


	}


}
