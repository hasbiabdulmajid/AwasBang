using UnityEngine;
using System.Collections;

public class pisau : MonoBehaviour {
	float speed;
	public GameObject stateManage;

	// Use this for initialization
	void Start () {
		speed = 40f;
		stateManage = GameObject.Find ("GameManager");
		
		
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (-speed, 0, 0);
		transform.Translate (Vector3.left * speed * Time.deltaTime);
		if (transform.position.x <= -11f) {
			Destroy (gameObject);
			GM pisaumentok = stateManage.GetComponent<GM> ();
			pisaumentok.state = "pause";
			pisaumentok.score += 1;
		}


	}
}
