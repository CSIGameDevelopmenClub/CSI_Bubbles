using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {
	public GameObject[] bg;
	public GameObject canvas;
	int rand;
	// Use this for initialization
	void Start () {
		rand = Random.Range (0, 4);
		var createBG=Instantiate (bg [rand]) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
