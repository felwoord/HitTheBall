﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private Rigidbody2D playerRB;
	private GameObject guideBall;

	public float movSpeed;
	public float jumpSpeed;
	public float shootSpeed;

	private int jumpNum = 1;

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
			Vector2 diretion = guideBall.transform.position - transform.position;

			playerRB.velocity = diretion * shootSpeed;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			//playerRB.AddForce (new Vector2(-movSpeed, 0));
			playerRB.velocity = new Vector2 (-movSpeed, playerRB.velocity.y);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			//playerRB.AddForce (new Vector2(movSpeed, 0));
			playerRB.velocity = new Vector2 (movSpeed, playerRB.velocity.y);
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			if (jumpNum > 0) {
				jumpNum--;
				playerRB.velocity = new Vector2 (playerRB.velocity.x, jumpSpeed);
			}
		}
	}

	public void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Block") {
			jumpNum = 2;
		}

		if (col.gameObject.tag == "GuideBall") {
			playerRB.velocity = new Vector2 (0, 0);

			if (jumpNum == 0) {
				jumpNum = 1;
			}
		}
	}
}
	