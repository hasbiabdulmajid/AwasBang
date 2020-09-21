using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	public GameObject spawner;
	float delay;
	Vector3 position;
	public GameObject gameManager;

	// Use this for initialization
	void Start () {
		delay = Random.Range (2f, 6f);
		gameManager = GameObject.Find ("GameManager");
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameManager.GetComponent<GM> ().GetState ().Equals("play")) { 
			delay -= Time.deltaTime;
			if (delay <= 0) {
				position = new Vector3 (18, Random.Range (-2f, 1.5f), 0);
				Instantiate (spawner, position, transform.rotation);
				delay = Random.Range (2f, 6f);
			}
		}
	
	}
}
