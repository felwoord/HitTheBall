using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour {
	private GameObject bottomSpikes;

	// Use this for initialization
	void Start () {
		bottomSpikes = GameObject.Find ("BottomSpikes");	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottomSpikes.transform.position.y - 15) {
			Destroy (gameObject);
		}
		
	}
}
