using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "GuideBall") {
			rb.velocity = new Vector2 (0, 0);
		}
	}
}
