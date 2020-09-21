using UnityEngine;
using System.Collections;

public class hand : MonoBehaviour {
	float speedhand;
	public GameObject stateManager;

	// Use this for initialization
	void Start () {
		speedhand = 80f;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) && transform.position.y <= 0) {
			//transform.Translate (0, speedhand, 0);
			transform.Translate (Vector3.up * speedhand * Time.deltaTime);

		}
			
		if (Input.GetKey(KeyCode.S) && transform.position.y >= -7) {
			transform.Translate (Vector3.down * speedhand * Time.deltaTime);
	
		}

			

	}
	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Finish") {
			Application.Quit ();;
		}



	}

	

}
