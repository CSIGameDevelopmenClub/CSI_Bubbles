using UnityEngine;
using System.Collections;

public class EnemyTap : MonoBehaviour {

	public WinCondition win;

	// Use this for initialization
	void Start () {
		win = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<WinCondition>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {

		gameObject.SetActive (false);
		win.currentEnemyCount --;
		//GameObject obj =GameObject.Find("Our Villian");
		//Rigidbody clone;
		//clone = Instantiate(obj,Vector3(0,0,0),Vector3(0,0,0))as Rigidbody;


	}
}
