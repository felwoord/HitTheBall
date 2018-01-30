using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScroll : MonoBehaviour {
	public float spikeSpeed;

	private GameObject bottomSpikes;
	private GameObject player;
	private GameObject guideBall;
	private GameObject lastWall;
	private GameObject nextWall;

	// Use this for initialization
	void Start () {
		bottomSpikes = GameObject.Find ("BottomSpikes");	
		player = GameObject.Find ("Player");
		guideBall = GameObject.Find ("GuideBall");
		lastWall = GameObject.Find("Walls");
		nextWall = Instantiate (Resources.Load ("Walls") as GameObject);
		nextWall.transform.position = new Vector2 (lastWall.transform.position.x, lastWall.transform.position.y + 10);
		lastWall = nextWall;

	}
	
	// Update is called once per frame
	void Update () {
		bottomSpikes.transform.position = new Vector2 (bottomSpikes.transform.position.x, bottomSpikes.transform.position.y + spikeSpeed);

		if (player.transform.position.y > lastWall.transform.position.y - 5 || guideBall.transform.position.y > lastWall.transform.position.y - 5f) {
			nextWall = Instantiate (Resources.Load ("Walls") as GameObject);
			nextWall.transform.position = new Vector2 (lastWall.transform.position.x, lastWall.transform.position.y + 10);
			lastWall = nextWall;

			CreateBlocks ();

			spikeSpeed = spikeSpeed + 0.001f;
		}

	}

	private void CreateBlocks(){
		int a = Random.Range (0, 2);
		Debug.Log (a);

		switch (a) {
		case 0:
			GameObject block1 = Instantiate (Resources.Load ("Block") as GameObject);
			block1.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(-5,-3)));
			GameObject block2 = Instantiate (Resources.Load ("Block") as GameObject);
			block2.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(-3,0)));
			GameObject block3 = Instantiate (Resources.Load ("Block") as GameObject);
			block3.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(0,3)));
			GameObject block4 = Instantiate (Resources.Load ("Block") as GameObject);
			block4.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(3,5)));
			break;
		case 1:
			GameObject block5 = Instantiate (Resources.Load ("Block") as GameObject);
			block5.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(-5,-1)));
			GameObject block6 = Instantiate (Resources.Load ("Block") as GameObject);
			block6.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(-1,2)));
			GameObject block7 = Instantiate (Resources.Load ("Block") as GameObject);
			block7.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(2,5)));
			GameObject block8 = Instantiate (Resources.Load ("Block") as GameObject);
			block8.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(-1,2)));
			GameObject block9 = Instantiate (Resources.Load ("Block") as GameObject);
			block9.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(2,5)));
			break;
		case 2:
			GameObject block10 = Instantiate (Resources.Load ("Block") as GameObject);
			block10.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(-5,-3)));
			GameObject block11 = Instantiate (Resources.Load ("Block") as GameObject);
			block11.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(-3,-1)));
			GameObject block12 = Instantiate (Resources.Load ("Block") as GameObject);
			block12.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(-1,1)));
			GameObject block13 = Instantiate (Resources.Load ("Block") as GameObject);
			block13.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(1,3)));
			GameObject block14 = Instantiate (Resources.Load ("Block") as GameObject);
			block14.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(3,5)));
			GameObject block15 = Instantiate (Resources.Load ("Block") as GameObject);
			block15.transform.position = new Vector2 (Random.Range(-7.4f,7.4f),lastWall.transform.position.y + (Random.Range(-5,5)));

			break;
		case 3:
			break;
		case 4:
			break;
		default:
			break;
		}
	}
}
