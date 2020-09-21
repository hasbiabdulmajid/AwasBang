using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class GM : MonoBehaviour {
	public string state;
	public int score;

	// Use this for initialization
	void Start () {
		state = "pause";
		score = 0;

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			state = "play";
		}
	}
	
	public string GetState() {
		return state;
	}


}
