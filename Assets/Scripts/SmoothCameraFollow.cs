using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour {
	private Transform playerTransf;
	private Vector2 newPos;

	// Use this for initialization
	void Start () {
		playerTransf = GameObject.Find ("Player").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		newPos = Vector2.Lerp (transform.position, playerTransf.position, 0.05f);
		transform.position = new Vector3 (newPos.x, newPos.y, -10);
	}
}
