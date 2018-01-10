using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssemblyCSharp;

public class GameController : MonoBehaviour {
	// Use this for initialization
	private GameObject playerGO;
	private GameObject guideBallGO;

	private Rigidbody2D playerRB;

	private PlayerMov player;
	public float playerSpeed = 0;

	void Start () {
		playerGO = GameObject.Find ("Player");
		guideBallGO = GameObject.Find ("GuideBall");

		playerRB = playerGO.GetComponent<Rigidbody2D> ();	
		player = new PlayerMov (playerSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.S)) {
			Action ();
		}
		if (Input.GetKey (KeyCode.A)){
			playerRB.velocity = new Vector2 (-3, playerRB.velocity.y);
		}
		if (Input.GetKey (KeyCode.D)){
			playerRB.velocity = new Vector2 (3, playerRB.velocity.y);
		}
		if (Input.GetKey (KeyCode.W)){
			playerRB.velocity = new Vector2  (playerRB.velocity.x, 3);
		}

		if (playerGO.transform.position.x > guideBallGO.transform.position.x) {
			playerGO.transform.position = new Vector2 (guideBallGO.transform.position.x, playerGO.transform.position.y);
		}
		
	}


	public void Action(){
		Vector2 direction = guideBallGO.transform.position - playerGO.transform.position;
		playerRB.velocity = player.SpeedCalc (direction);
	}
}
