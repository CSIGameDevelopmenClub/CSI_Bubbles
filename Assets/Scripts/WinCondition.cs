using UnityEngine;
using System.Collections;

public class WinCondition : MonoBehaviour {

	public int baseEnemyCount;
	public int currentEnemyCount;

	// Use this for initialization
	void Start () {

		currentEnemyCount = baseEnemyCount;

	}
	
	// Update is called once per frame
	void Update () {

		if (currentEnemyCount == 0) 
		{
			Application.LoadLevel ("Level2");
			//GameObject obj =GameObject.Find("Our Villian");
			//Rigidbody clone;
			//clone= Instantiate(obj,Vector3(0,0,0),Vector3(0,0,0));

		}
	
	}
}
