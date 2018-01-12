using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private Rigidbody2D playerRB;
	private GameObject guideBall;

	public float movSpeed;

	// Use this for initialization
	void Start () {
		playerRB = GetComponent<Rigidbody2D> ();
		guideBall = GameObject.Find ("GuideBall");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			Movement ();
		}
	}

	private void Movement(){
		if(Input.GetKeyDown(KeyCode.S)){
			Debug.Log ("SS");
		}
		if (Input.GetKey (KeyCode.A)) {
			playerRB.velocity = new Vector2 (-10, playerRB.velocity.y);
		}
		if (Input.GetKey (KeyCode.D)) {
			
		}
	}
}


///chao tag = Block