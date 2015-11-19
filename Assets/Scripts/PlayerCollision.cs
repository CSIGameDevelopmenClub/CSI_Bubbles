using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {

	int lives = 5;
	public Text livesText;
	public Text gameOver;

	// Use this for initialization
	void Start () {

		//livesText = GetComponent<Text>();

	
	}
	
	// Update is called once per frame
	void Update () {
		livesText.text = lives.ToString ();

		if (lives ==0) {
			gameObject.SetActive (false);
			//gameOver.setActive(true);
			gameOver.gameObject.SetActive (true);

		}

	}

	void OnTriggerEnter2D (Collider2D other) {

		if (other.gameObject.tag == "Enemy")
		{
			Debug.Log ("ENEMY HIT");
			lives --;
		}

	}

	public void testClick() {
		Debug.Log ("CLICK");
	}
}


