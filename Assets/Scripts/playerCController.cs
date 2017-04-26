using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCController : MonoBehaviour {

	public Rigidbody player;
	public float speed = 5.0f;

	public Vector3 doorAcoord = new Vector3 (1.5f, 0.5f, 12.5f);
	public Vector3 doorBcoord = new Vector3 (3.5f, 0.5f, 12.5f);
	public Vector3 doorCcoord = new Vector3 (4.5f, 0.5f, 12.5f);
	public Vector3 doorDcoord = new Vector3 (11.5f, 0.5f, 13.5f);
	public Vector3 doorEcoord = new Vector3 (0.5f, 0.5f, 9.5f);
	public Vector3 doorFcoord = new Vector3 (3.5f, 0.5f, 10.5f);
	public Vector3 doorGcoord = new Vector3 (12.5f, 0.5f, 11.5f);
	public Vector3 doorHcoord = new Vector3 (12.5f, 0.5f, 9.5f);
	public Vector3 doorIcoord = new Vector3 (3.5f, 0.5f, 7.5f);
	public Vector3 doorJcoord = new Vector3 (10.5f, 0.5f, 7.5f);
	public Vector3 doorKcoord = new Vector3 (12.5f, 0.5f, 5.5f);
	public Vector3 doorLcoord = new Vector3 (3.5f, 0.5f, 3.5f);
	public Vector3 doorMcoord = new Vector3 (7.5f, 0.5f, 3.5f);
	public Vector3 doorNcoord = new Vector3 (8.5f, 0.5f, 3.5f);
	public Vector3 doorOcoord = new Vector3 (12.5f, 0.5f, 3.5f);
	public Vector3 doorPcoord = new Vector3 (7.0f, 0.5f, 4.5f);
	public static string currDoor = "";

	Dictionary<string, Vector3> doorCoords = new Dictionary<string, Vector3>();

	void Update(){
		if (gameManager.toggleC == true) {
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				//if(ArduinoController.moveUp){
				movePlayerUp ();
				ArduinoController.moveUp = false;
			}
			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				//if(ArduinoController.moveDown){
				movePlayerDown ();
				ArduinoController.moveDown = false;
			}
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				//if(ArduinoController.moveLeft){
				movePlayerLeft ();
				ArduinoController.moveLeft = false;
			}
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				//if(ArduinoController.moveRight){	
				movePlayerRight ();
				ArduinoController.moveRight = false;
			}
		}

		if (player.position.x * 10 % 5 != 0 || player.position.z * 10 % 5 != 0){
			float currentX = player.position.x;
			float currentZ = player.position.z;
			float fixX = player.position.x;
			float fixZ = player.position.z;
			fixX = Mathf.Round(fixX*10)/10;
			fixZ = Mathf.Round(fixZ*10)/10;
			transform.Translate (fixX - currentX, 0.0f, fixZ - currentZ);
		}
	}

	void movePlayerUp() {
		float currentX = player.position.x;
		float currentZ = player.position.z;
		if (currentX == 0.5f && currentZ == 9.5f) {
			currDoor = "doorA";
			transform.Translate (doorAcoord.x - currentX, 0.0f, doorAcoord.z - currentZ);
		}
		if (currentX == 3.5f && currentZ == 10.5f) {
			currDoor = "doorB";
			transform.Translate (doorBcoord.x - currentX, 0.0f, doorBcoord.z - currentZ);
		}
		if (currentX == 12.5f && currentZ == 11.5f) {
			currDoor = "doorD";
			transform.Translate (doorDcoord.x - currentX, 0.0f, doorDcoord.z - currentZ);
		}
		if (currentX == 12.5f && currentZ == 9.5f) {
			currDoor = "doorG";
			transform.Translate (doorGcoord.x - currentX, 0.0f, doorGcoord.z - currentZ);
		}
		if (currentX == 3.5f && currentZ == 7.5f) {
			currDoor = "doorF";
			transform.Translate (doorFcoord.x - currentX, 0.0f, doorFcoord.z - currentZ);
		}
		if (currentX == 10.5f && currentZ == 7.5f) {
			currDoor = "doorG";
			transform.Translate (doorGcoord.x - currentX, 0.0f, doorGcoord.z - currentZ);
		}
		if (currentX == 12.5f && currentZ == 5.5f) {
			currDoor = "doorJ";
			transform.Translate (doorJcoord.x - currentX, 0.0f, doorJcoord.z - currentZ);
		}
		if (currentX == 3.5f && currentZ == 3.5f) {
			currDoor = "doorI";
			transform.Translate (doorIcoord.x - currentX, 0.0f, doorIcoord.z - currentZ);
		}
		if (currentX == 8.5f && currentZ == 3.5f) {
			currDoor = "doorJ";
			transform.Translate (doorJcoord.x - currentX, 0.0f, doorJcoord.z - currentZ);
		}
		if (currentX == 12.5f && currentZ == 3.5f) {
			currDoor = "doorK";
			transform.Translate (doorKcoord.x - currentX, 0.0f, doorKcoord.z - currentZ);
		}
		if (currentX == 3.5f && currentZ == 1.5f) {
			currDoor = "doorL";
			transform.Translate (doorLcoord.x - currentX, 0.0f, doorLcoord.z - currentZ);
		}

	}

	void movePlayerDown() {
		float currentX = player.position.x;
		float currentZ = player.position.z;
		if (currentX == 1.5f && currentZ == 12.5f) {
			currDoor = "doorF";
			transform.Translate (doorFcoord.x - currentX, 0.0f, doorFcoord.z - currentZ);
		}
		if (currentX == 3.5f && currentZ == 12.5f) {
			currDoor = "doorF";
			transform.Translate (doorFcoord.x - currentX, 0.0f, doorFcoord.z - currentZ);
		}
		if (currentX == 4.5f && currentZ == 12.5f) {
			currDoor = "doorG";
			transform.Translate (doorGcoord.x - currentX, 0.0f, doorGcoord.z - currentZ);
		}
		if (currentX == 12.5f && currentZ == 9.5f) {
			currDoor = "doorI";
			transform.Translate (doorIcoord.x - currentX, 0.0f, doorIcoord.z - currentZ);
		}
		if (currentX == 3.5f && currentZ == 10.5f) {
			currDoor = "doorI";
			transform.Translate (doorIcoord.x - currentX, 0.0f, doorIcoord.z - currentZ);
		}
		if (currentX == 12.5f && currentZ == 11.5f) {
			currDoor = "doorH";
			transform.Translate (doorHcoord.x - currentX, 0.0f, doorHcoord.z - currentZ);
		}
		if (currentX == 3.5f && currentZ == 7.5f) {
			currDoor = "doorL";
			transform.Translate (doorLcoord.x - currentX, 0.0f, doorLcoord.z - currentZ);
		}
		if (currentX == 10.5f && currentZ == 7.5f) {
			currDoor = "doorN";
			transform.Translate (doorNcoord.x - currentX, 0.0f, doorNcoord.z - currentZ);
		}
		if (currentX == 12.5f && currentZ == 5.5f) {
			currDoor = "doorO";
			transform.Translate (doorOcoord.x - currentX, 0.0f, doorOcoord.z - currentZ);
		}
	}

	void movePlayerLeft() {
		float currentX = player.position.x;
		float currentZ = player.position.z;
		if (currentX == 3.5f && currentZ == 12.5f) {
			currDoor = "doorA";
			transform.Translate (doorAcoord.x - currentX, 0.0f, doorAcoord.z - currentZ);
		}
		if (currentX == 4.5f && currentZ == 12.5f) {
			currDoor = "doorB";
			transform.Translate (doorBcoord.x - currentX, 0.0f, doorBcoord.z - currentZ);
		}
		if (currentX == 11.5f && currentZ == 13.5f) {
			currDoor = "doorC";
			transform.Translate (doorCcoord.x - currentX, 0.0f, doorCcoord.z - currentZ);
		}
		if (currentX == 3.5f && currentZ == 10.5f) {
			currDoor = "doorE";
			transform.Translate (doorEcoord.x - currentX, 0.0f, doorEcoord.z - currentZ);
		}
		if (currentX == 12.5f && currentZ == 11.5f) {
			currDoor = "doorC";
			transform.Translate (doorCcoord.x - currentX, 0.0f, doorCcoord.z - currentZ);
		}
		if (currentX == 3.5f && currentZ == 7.5f) {
			currDoor = "doorE";
			transform.Translate (doorEcoord.x - currentX, 0.0f, doorEcoord.z - currentZ);
		}
		if (currentX == 10.5f && currentZ == 7.5f) {
			currDoor = "doorP";
			transform.Translate (doorPcoord.x - currentX, 0.0f, doorPcoord.z - currentZ);
		}
		if (currentX == 12.5f && currentZ == 5.5f) {
			currDoor = "doorJ";
			transform.Translate (doorJcoord.x - currentX, 0.0f, doorJcoord.z - currentZ);
		}
		if (currentX == 7.5f && currentZ == 3.5f) {
			currDoor = "doorL";
			transform.Translate (doorLcoord.x - currentX, 0.0f, doorLcoord.z - currentZ);
		}
		if (currentX == 8.5f && currentZ == 3.5f) {
			currDoor = "doorM";
			transform.Translate (doorMcoord.x - currentX, 0.0f, doorMcoord.z - currentZ);
		}
		if (currentX == 12.5f && currentZ == 3.5f) {
			currDoor = "doorN";
			transform.Translate (doorNcoord.x - currentX, 0.0f, doorNcoord.z - currentZ);
		}
		if (currentX == 7.0f && currentZ == 4.5f) {
			currDoor = "doorI";
			transform.Translate (doorIcoord.x - currentX, 0.0f, doorIcoord.z - currentZ);
		}
	}

	void movePlayerRight() {
		float currentX = player.position.x;
		float currentZ = player.position.z;
		if (currentX == 1.5f && currentZ == 12.5f) {
			currDoor = "doorB";
			transform.Translate (doorBcoord.x - currentX, 0.0f, doorBcoord.z - currentZ);
		}
		if (currentX == 3.5f && currentZ == 12.5f) {
			currDoor = "doorC";
			transform.Translate (doorCcoord.x - currentX, 0.0f, doorCcoord.z - currentZ);
		}
		if (currentX == 4.5f && currentZ == 12.5f) {
			currDoor = "doorG";
			transform.Translate (doorGcoord.x - currentX, 0.0f, doorGcoord.z - currentZ);
		}
		if (currentX == 0.5f && currentZ == 9.5f) {
			currDoor = "doorF";
			transform.Translate (doorFcoord.x - currentX, 0.0f, doorFcoord.z - currentZ);
		}
		if (currentX == 3.5f && currentZ == 10.5f) {
			currDoor = "doorG";
			transform.Translate (doorGcoord.x - currentX, 0.0f, doorGcoord.z - currentZ);
		}
		if (currentX == 3.5f && currentZ == 7.5f) {
			currDoor = "doorP";
			transform.Translate (doorPcoord.x - currentX, 0.0f, doorPcoord.z - currentZ);
		}
		if (currentX == 10.5f && currentZ == 7.5f) {
			currDoor = "doorK";
			transform.Translate (doorKcoord.x - currentX, 0.0f, doorKcoord.z - currentZ);
		}
		if (currentX == 3.5f && currentZ == 3.5f) {
			currDoor = "doorM";
			transform.Translate (doorMcoord.x - currentX, 0.0f, doorMcoord.z - currentZ);
		}
		if (currentX == 7.5f && currentZ == 3.5f) {
			currDoor = "doorN";
			transform.Translate (doorNcoord.x - currentX, 0.0f, doorNcoord.z - currentZ);
		}
		if (currentX == 8.5f && currentZ == 3.5f) {
			currDoor = "doorO";
			transform.Translate (doorOcoord.x - currentX, 0.0f, doorOcoord.z - currentZ);
		}
		if (currentX == 7.0f && currentZ == 4.5f) {
			currDoor = "doorJ";
			transform.Translate (doorJcoord.x - currentX, 0.0f, doorJcoord.z - currentZ);
		}
	}
}
