using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Transform player;
	float playerHeightY;



	public Transform Jump;
	public Transform Leftright;
	public Transform Updown;
	public Transform OneTime;

	private int platNumber;
	private float platCheck;
	private float spawnPlatformsTo=10;

	void Start(){
	
		player = GameObject.FindGameObjectWithTag ("Player").transform;

		//PlatformSwap (2);
	}

	void Update(){
	
		playerHeightY = player.position.y;

		if (playerHeightY > platCheck) {
		
			PlatformManager ();
		}

		float currentCameraHeight = transform.position.y;
		float newHeightOfCamera = Mathf.Lerp (currentCameraHeight, playerHeightY, Time.deltaTime * 10);
		if (playerHeightY > currentCameraHeight) {
		
			transform.position = new Vector3 (transform.position.x, newHeightOfCamera-0.01f, transform.position.z);
		}
		else {
		
			if (playerHeightY < (currentCameraHeight - 5.6)) {
			
				SceneManager.LoadScene ("S2_jump");
			}
		}

		if (playerHeightY > OnGUI2D.score) {
		
			OnGUI2D.score = (int)playerHeightY;
		}
	}

	void PlatformManager(){
		platCheck = player.position.y + 1000;
		PlatformSwap (platCheck + 1000);

	}

	void PlatformSwap(float floatValue){

		float y = spawnPlatformsTo;
		while (y <= floatValue) {
			float x = Random.Range (-3.32f, 3.32f);

			if (y <= 200f) {
				platNumber = Random.Range (1, 4);
			} else {
				platNumber = Random.Range (1, 5);
			}

			Vector2 posXY = new Vector2 (x, y);


			if (platNumber == 1) {	
				Instantiate (Jump, posXY, Quaternion.identity);
			}

			if (platNumber == 2) {	
				Instantiate (Leftright, posXY, Quaternion.identity);
			}

			if (platNumber == 3) {	
				Instantiate (Updown, posXY, Quaternion.identity);
			}

			if (platNumber == 4) {	
				Instantiate (OneTime, posXY, Quaternion.identity);
			}
			y += Random.Range (1f, 3f);
			Debug.Log ("Spawn Platform");
		}

		spawnPlatformsTo = floatValue;


	}
}
