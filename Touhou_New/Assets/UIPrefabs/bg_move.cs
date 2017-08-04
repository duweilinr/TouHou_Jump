using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg_move : MonoBehaviour {
	
	public Transform player;
	float playerHeightY;
	// Use this for initialization
	private Vector2 velocity;
	public float smoothTimeY;


	void Start(){

		player = GameObject.FindGameObjectWithTag ("MainCamera").transform;

		//PlatformSwap (2);
	}
	void Update(){

		float posY = Mathf.SmoothDamp (transform.position.y, player.position.y, ref velocity.y, smoothTimeY);
		transform.position = new Vector3 (transform.position.x, posY, transform.position.z);


		if (playerHeightY > OnGUI2D.score) {

			OnGUI2D.score = (int)playerHeightY;
		}
	}
}
