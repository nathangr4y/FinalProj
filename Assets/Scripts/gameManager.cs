using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {
	
	public static bool toggleA = true;
	public static bool toggleB = false;
	public static bool toggleC = false;
	public Rigidbody playerA;
	public Rigidbody playerB;
	public Rigidbody playerC;
	public Rigidbody activePlayer;
	public Rigidbody enemy;
	private GameObject goEnemy;
	float Timer = 0.0f;
	public static int randAdj = 0;
	public static int randRm = Random.Range (0, 17);
	static Vector3 rmAcoord = new Vector3 (1.5f, 0.5f, 13.5f);
	static Vector3 rmBcoord = new Vector3 (6.5f, 0.5f, 13.5f);
	static Vector3 rmCcoord = new Vector3 (9.5f, 0.5f, 13.5f);
	static Vector3 rmDcoord = new Vector3 (13.5f, 0.5f, 13.5f);
	static Vector3 rmEcoord = new Vector3 (0.5f, 0.5f, 10.5f);
	static Vector3 rmFcoord = new Vector3 (4.5f, 0.5f, 11.5f);
	static Vector3 rmGcoord = new Vector3 (11.5f, 0.5f, 10.5f);
	static Vector3 rmHcoord = new Vector3 (14.5f, 0.5f, 10.5f);
	static Vector3 rmIcoord = new Vector3 (1.5f, 0.5f, 7.5f);
	static Vector3 rmJcoord = new Vector3 (5.5f, 0.5f, 5.5f);
	static Vector3 rmKcoord = new Vector3 (8.5f, 0.5f, 5.5f);
	static Vector3 rmLcoord = new Vector3 (13.5f, 0.5f, 7.5f);
	static Vector3 rmMcoord = new Vector3 (1.5f, 0.5f, 4.5f);
	static Vector3 rmNcoord = new Vector3 (14.5f, 0.5f, 4.5f);
	static Vector3 rmOcoord = new Vector3 (1.5f, 0.5f, 1.5f);
	static Vector3 rmPcoord = new Vector3 (5.5f, 0.5f, 1.5f);
	static Vector3 rmQcoord = new Vector3 (10.5f, 0.5f, 1.5f);
	static Vector3 rmRcoord = new Vector3 (13.5f, 0.5f, 1.5f);
	public static string currRm = "";
	public static bool victory = false;


	// Use this for initialization
	void Start () {
		//createEnemy ();
		//Destroy (GameObject.FindGameObjectWithTag ("Enemy"));
	}
	
	// Update is called once per frame
	void Update () {
		//Victory
		victoryCheck();
		if (victory) {
			print ("currDoorA: " + playerAController.currDoor + " currDoorB: " + playerBController.currDoor + " currDoorC: " + playerCController.currDoor);
			print ("currRm: " + currRm);
			int printCount = 0;
			while (printCount < 2) {
				//print ("YOU WON!");
				printCount++;
			}
			enemyController.rend.enabled = true;
			Time.timeScale = 0.0f;
		}

		if (countdownTimer.defeat) {
			//print ("YOU LOST!");
			enemyController.rend.enabled = true;
			Time.timeScale = 0.0f;
		}

		//if (!victory) {
			Timer += Time.deltaTime;
		//}
		if(Timer >= 3.0f){
			Destroy (GameObject.FindGameObjectWithTag ("Enemy"));
			moveEnemy ();
			Timer = 0.0f;
		}
			
		if (Input.GetKeyDown (KeyCode.Return)) {
		//if(ArduinoController.buttonDown == true){
			if (toggleA == true) {
				print ("TOG B");
				activePlayer = playerA;
				toggleA = false;
				toggleB = true;
				toggleC = false;
			} else if (toggleB == true) {
				print ("TOG C");
				activePlayer = playerB;
				toggleA = false;
				toggleB = false;
				toggleC = true;
			} else if (toggleC == true) {
				print ("TOG A");
				activePlayer = playerC;
				toggleA = true;
				toggleB = false;
				toggleC = false;
			}
		}
			
		//Toggle HALO
		if(gameManager.toggleA == true){
			Component halo = playerA.GetComponent ("Halo"); halo.GetType ().GetProperty ("enabled").SetValue (halo, true, null);
		}
		if(gameManager.toggleA == false){
			Component halo = playerA.GetComponent ("Halo"); halo.GetType ().GetProperty ("enabled").SetValue (halo, false, null);
		}
		if(gameManager.toggleB == true){
			Component halo = playerB.GetComponent ("Halo"); halo.GetType ().GetProperty ("enabled").SetValue (halo, true, null);
		}
		if(gameManager.toggleB == false){
			Component halo = playerB.GetComponent ("Halo"); halo.GetType ().GetProperty ("enabled").SetValue (halo, false, null);
		}
		if(gameManager.toggleC == true){
			Component halo = playerC.GetComponent ("Halo"); halo.GetType ().GetProperty ("enabled").SetValue (halo, true, null);
		}
		if(gameManager.toggleC == false){
			Component halo = playerC.GetComponent ("Halo"); halo.GetType ().GetProperty ("enabled").SetValue (halo, false, null);
		}
	}

	void createEnemy(){
		randRm = Random.Range (0, 15);
		if (randRm == 0) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmAcoord, transform.rotation);
		} else if (randRm == 1) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmBcoord, transform.rotation);
		} else if (randRm == 2) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmCcoord, transform.rotation);
		} else if (randRm == 3) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmDcoord, transform.rotation);
		} else if (randRm == 4) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmEcoord, transform.rotation);
		} else if (randRm == 5) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmFcoord, transform.rotation);
		} else if (randRm == 6) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmGcoord, transform.rotation);
		} else if (randRm == 7) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmHcoord, transform.rotation);
		} else if (randRm == 8) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmIcoord, transform.rotation);
		} else if (randRm == 9) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmJcoord, transform.rotation);
		} else if (randRm == 10) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmKcoord, transform.rotation);
		} else if (randRm == 11) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmLcoord, transform.rotation);
		} else if (randRm == 12) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmNcoord, transform.rotation);
		} else if (randRm == 13) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmQcoord, transform.rotation);
		} else if (randRm == 14) {
			Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, gameManager.rmRcoord, transform.rotation);
		}
	}

	public void moveEnemy(){
		if (gameManager.randRm == 0) {
			//put a validMove() check here, if true, go, if false, re-roll:
			print ("rmA");
			currRm = "rmA";
			randAdj = Random.Range (0, 3);
			if (randAdj == 0) {
				if(playerAController.currDoor.Equals("doorC") || playerBController.currDoor.Equals("doorC") || playerCController.currDoor.Equals("doorC")){
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmAcoord, transform.rotation);
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmBcoord, transform.rotation);
					randRm = 0;
				}
			} else if (randAdj == 1) {
				if(playerAController.currDoor.Equals("doorA") || playerBController.currDoor.Equals("doorA") || playerCController.currDoor.Equals("doorA")){
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmAcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmEcoord, transform.rotation);
					randRm = 1;
				}
			} else if (randAdj == 2) {
				if (playerAController.currDoor.Equals ("doorF") || playerBController.currDoor.Equals ("doorF") || playerCController.currDoor.Equals ("doorF")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmAcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmFcoord, transform.rotation);
					randRm = 2;
				}
			}
		} else if (gameManager.randRm == 1) {
			print ("rmB");
			currRm = "rmB";
			randAdj = Random.Range (0, 3);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorB") || playerBController.currDoor.Equals ("doorB") || playerCController.currDoor.Equals ("doorB")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmBcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmAcoord, transform.rotation);
					randRm = 0;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorF") || playerBController.currDoor.Equals ("doorF") || playerCController.currDoor.Equals ("doorF")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmBcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmFcoord, transform.rotation);
					randRm = 5;
				}
			} else if (randAdj == 2) {
				if (playerAController.currDoor.Equals ("doorD") || playerBController.currDoor.Equals ("doorD") || playerCController.currDoor.Equals ("doorD")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmBcoord, transform.rotation);						
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmCcoord, transform.rotation);
					randRm = 3;
				}
			}
		} else if (gameManager.randRm == 2) {
			print ("rmC");
			currRm = "rmC";
			randAdj = Random.Range (0, 3);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorC") || playerBController.currDoor.Equals ("doorC") || playerCController.currDoor.Equals ("doorC")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmCcoord, transform.rotation);						
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmBcoord, transform.rotation);
					randRm = 1;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorG") || playerBController.currDoor.Equals ("doorG") || playerCController.currDoor.Equals ("doorG")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmCcoord, transform.rotation);						
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmGcoord, transform.rotation);
					randRm = 6;
				}
			} else if (randAdj == 2) {
				if (playerAController.currDoor.Equals ("doorD") || playerBController.currDoor.Equals ("doorD") || playerCController.currDoor.Equals ("doorD")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmCcoord, transform.rotation);						
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmDcoord, transform.rotation);
					randRm = 3;
				}
			}
		} else if (gameManager.randRm == 3) {
			print ("rmD");
			currRm = "rmD";
			randAdj = Random.Range (0, 3);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorD") || playerBController.currDoor.Equals ("doorD") || playerCController.currDoor.Equals ("doorD")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmDcoord, transform.rotation);						
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmCcoord, transform.rotation);
					randRm = 2;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorG") || playerBController.currDoor.Equals ("doorG") || playerCController.currDoor.Equals ("doorG")
					|| playerAController.currDoor.Equals ("doorH") || playerBController.currDoor.Equals ("doorH") || playerCController.currDoor.Equals ("doorH")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmDcoord, transform.rotation);						
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmGcoord, transform.rotation);
					randRm = 6;
				}
			} else if (randAdj == 2) {
				if (playerAController.currDoor.Equals ("doorH") || playerBController.currDoor.Equals ("doorH") || playerCController.currDoor.Equals ("doorH")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmDcoord, transform.rotation);						
				} else {				
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmHcoord, transform.rotation);
					randRm = 7;
				}
			}
		} else if (gameManager.randRm == 4) {
			print ("rmE");
			currRm = "rmE";
			randAdj = Random.Range (0, 3);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorB") || playerBController.currDoor.Equals ("doorB") || playerCController.currDoor.Equals ("doorB")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmEcoord, transform.rotation);						
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmAcoord, transform.rotation);
					randRm = 0;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorF") || playerBController.currDoor.Equals ("doorF") || playerCController.currDoor.Equals ("doorF")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmEcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmFcoord, transform.rotation);
					randRm = 5;
				}
			} else if (randAdj == 2) {
				if (playerAController.currDoor.Equals ("doorE") || playerBController.currDoor.Equals ("doorE") || playerCController.currDoor.Equals ("doorE")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmEcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmIcoord, transform.rotation);
					randRm = 8;
				}
			}
		} else if (gameManager.randRm == 5) {
			print ("rmF");
			currRm = "rmF";
			randAdj = Random.Range (0, 4);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorB") || playerBController.currDoor.Equals ("doorB") || playerCController.currDoor.Equals ("doorB")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmFcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmAcoord, transform.rotation);
					randRm = 0;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorA") || playerBController.currDoor.Equals ("doorA") || playerCController.currDoor.Equals ("doorA")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmFcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmEcoord, transform.rotation);
					randRm = 4;
				}
			} else if (randAdj == 2) {
				if (playerAController.currDoor.Equals ("doorE") || playerBController.currDoor.Equals ("doorE") || playerCController.currDoor.Equals ("doorE")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmFcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmIcoord, transform.rotation);
					randRm = 8;
				}
			} else if (randAdj == 3) {
				if (playerAController.currDoor.Equals ("doorI") || playerBController.currDoor.Equals ("doorI") || playerCController.currDoor.Equals ("doorI")
					|| playerAController.currDoor.Equals ("doorP") || playerBController.currDoor.Equals ("doorP") || playerCController.currDoor.Equals ("doorP")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmFcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmJcoord, transform.rotation);
					randRm = 9;
				}
			}
		} else if (gameManager.randRm == 6) {
			print ("rmG");
			currRm = "rmG";
			randAdj = Random.Range (0, 3);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorD") || playerBController.currDoor.Equals ("doorD") || playerCController.currDoor.Equals ("doorD")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmGcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmCcoord, transform.rotation);
					randRm = 2;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorD") || playerBController.currDoor.Equals ("doorD") || playerCController.currDoor.Equals ("doorD")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmGcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmDcoord, transform.rotation);
					randRm = 3;
				}
			} else if (randAdj == 2) {
				if (playerAController.currDoor.Equals ("doorH") || playerBController.currDoor.Equals ("doorH") || playerCController.currDoor.Equals ("doorH")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmGcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmHcoord, transform.rotation);
					randRm = 7;
				}
			}
		} else if (gameManager.randRm == 7) {
			print ("rmH");
			currRm = "rmH";
			if (playerAController.currDoor.Equals ("doorG") || playerBController.currDoor.Equals ("doorG") || playerCController.currDoor.Equals ("doorG")
				|| playerAController.currDoor.Equals ("doorH") || playerBController.currDoor.Equals ("doorH") || playerCController.currDoor.Equals ("doorH")) {
				Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmHcoord, transform.rotation);				
			} else {
				Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmGcoord, transform.rotation);
				randRm = 6;
			}
		} else if (gameManager.randRm == 8) {
			print ("rmI");
			currRm = "rmI";
			randAdj = Random.Range (0, 2);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorF") || playerBController.currDoor.Equals ("doorF") || playerCController.currDoor.Equals ("doorF")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmIcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmFcoord, transform.rotation);
					randRm = 5;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorI") || playerBController.currDoor.Equals ("doorI") || playerCController.currDoor.Equals ("doorI")
					|| playerAController.currDoor.Equals ("doorP") || playerBController.currDoor.Equals ("doorP") || playerCController.currDoor.Equals ("doorP")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmIcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmJcoord, transform.rotation);
					randRm = 9;
				}
			}
		} else if (gameManager.randRm == 9) {
			print ("rmJ");
			currRm = "rmJ";
			randAdj = Random.Range (0, 3);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorF") || playerBController.currDoor.Equals ("doorF") || playerCController.currDoor.Equals ("doorF")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmJcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmFcoord, transform.rotation);
					randRm = 5;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorE") || playerBController.currDoor.Equals ("doorE") || playerCController.currDoor.Equals ("doorE")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmJcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmIcoord, transform.rotation);
					randRm = 8;
				}
			} else if (randAdj == 2) {
				if (playerAController.currDoor.Equals ("doorL") || playerBController.currDoor.Equals ("doorL") || playerCController.currDoor.Equals ("doorL")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmJcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmMcoord, transform.rotation);
					randRm = 12;
				}
			}
		} else if (gameManager.randRm == 10) {
			print ("rmK");
			currRm = "rmK";
			randAdj = Random.Range (0, 2);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorI") || playerBController.currDoor.Equals ("doorI") || playerCController.currDoor.Equals ("doorI")
					|| playerAController.currDoor.Equals ("doorP") || playerBController.currDoor.Equals ("doorP") || playerCController.currDoor.Equals ("doorP")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmKcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmJcoord, transform.rotation);
					randRm = 9;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorK") || playerBController.currDoor.Equals ("doorK") || playerCController.currDoor.Equals ("doorK")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmKcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmLcoord, transform.rotation);
					randRm = 11;
				}
			}
		} else if (gameManager.randRm == 11) {
			print ("rmL");
			currRm = "rmL";
			randAdj = Random.Range (0, 2);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorJ") || playerBController.currDoor.Equals ("doorJ") || playerCController.currDoor.Equals ("doorJ")
					|| playerAController.currDoor.Equals ("doorP") || playerBController.currDoor.Equals ("doorP") || playerCController.currDoor.Equals ("doorP")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmLcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmKcoord, transform.rotation);
					randRm = 10;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorO") || playerBController.currDoor.Equals ("doorO") || playerCController.currDoor.Equals ("doorO")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmLcoord, transform.rotation);						
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmNcoord, transform.rotation);
					randRm = 13;
				}
			}
		} else if (gameManager.randRm == 12) {
			print ("rmM");
			currRm = "rmM";
			randAdj = Random.Range (0, 2);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorK") || playerBController.currDoor.Equals ("doorK") || playerCController.currDoor.Equals ("doorK")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmMcoord, transform.rotation);						
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmJcoord, transform.rotation);
					randRm = 9;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorL") || playerBController.currDoor.Equals ("doorL") || playerCController.currDoor.Equals ("doorL")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmMcoord, transform.rotation);						
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmOcoord, transform.rotation);
					randRm = 14;
				}
			}
		} else if (gameManager.randRm == 13) {
			print ("rmN");
			currRm = "rmN";
			randAdj = Random.Range (0, 2);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorO") || playerBController.currDoor.Equals ("doorO") || playerCController.currDoor.Equals ("doorO")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmNcoord, transform.rotation);						
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmRcoord, transform.rotation);
					randRm = 17;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorK") || playerBController.currDoor.Equals ("doorK") || playerCController.currDoor.Equals ("doorK")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmNcoord, transform.rotation);						
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmLcoord, transform.rotation);
					randRm = 11;
				}
			}
		} else if (gameManager.randRm == 14) {
			print ("rmO");
			currRm = "rmO";
			randAdj = Random.Range (0, 2);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorM") || playerBController.currDoor.Equals ("doorM") || playerCController.currDoor.Equals ("doorM")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmOcoord, transform.rotation);						
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmPcoord, transform.rotation);
					randRm = 15;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorL") || playerBController.currDoor.Equals ("doorL") || playerCController.currDoor.Equals ("doorL")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmOcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmMcoord, transform.rotation);
					randRm = 12;
				}
			}
		} else if (gameManager.randRm == 15) {
			print ("rmP");
			currRm = "rmP";
			randAdj = Random.Range (0, 2);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorL") || playerBController.currDoor.Equals ("doorL") || playerCController.currDoor.Equals ("doorL")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmPcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmOcoord, transform.rotation);
					randRm = 14;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorN") || playerBController.currDoor.Equals ("doorN") || playerCController.currDoor.Equals ("doorN")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmPcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmQcoord, transform.rotation);
					randRm = 16;
				}
			}
		} else if (gameManager.randRm == 16) {
			print ("rmQ");
			currRm = "rmQ";
			randAdj = Random.Range (0, 2);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorM") || playerBController.currDoor.Equals ("doorM") || playerCController.currDoor.Equals ("doorM")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmQcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmPcoord, transform.rotation);
					randRm = 15;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorO") || playerBController.currDoor.Equals ("doorO") || playerCController.currDoor.Equals ("doorO")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmQcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmRcoord, transform.rotation);
					randRm = 17;
				}
			}
		} else if (gameManager.randRm == 17) {
			print ("rmR");
			currRm = "rmR";
			randAdj = Random.Range (0, 2);
			if (randAdj == 0) {
				if (playerAController.currDoor.Equals ("doorO") || playerBController.currDoor.Equals ("doorO") || playerCController.currDoor.Equals ("doorO")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmRcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmNcoord, transform.rotation);
					randRm = 13;
				}
			} else if (randAdj == 1) {
				if (playerAController.currDoor.Equals ("doorN") || playerBController.currDoor.Equals ("doorN") || playerCController.currDoor.Equals ("doorN")) {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmRcoord, transform.rotation);					
				} else {
					Rigidbody enemyNPC = (Rigidbody)Instantiate (enemy, rmQcoord, transform.rotation);
					randRm = 16;
				}
			}
		}
	}


	void victoryCheck(){
		if ((playerAController.currDoor.Equals("doorB") || playerBController.currDoor.Equals("doorB") || playerCController.currDoor.Equals("doorB")) && currRm.Equals("rmA")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorC") || playerBController.currDoor.Equals("doorC") || playerCController.currDoor.Equals("doorC")) && currRm.Equals("rmB")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorD") || playerBController.currDoor.Equals("doorD") || playerCController.currDoor.Equals("doorD")) && currRm.Equals("rmC")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorD") || playerBController.currDoor.Equals("doorD") || playerCController.currDoor.Equals("doorD")) && currRm.Equals("rmD")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorA") || playerBController.currDoor.Equals("doorA") || playerCController.currDoor.Equals("doorA")) && currRm.Equals("rmE")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorF") || playerBController.currDoor.Equals("doorF") || playerCController.currDoor.Equals("doorF")) && currRm.Equals("rmF")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorG") || playerBController.currDoor.Equals("doorG") || playerCController.currDoor.Equals("doorG")
			|| (playerAController.currDoor.Equals("doorH") || playerBController.currDoor.Equals("doorH") || playerCController.currDoor.Equals("doorH"))) && currRm.Equals("rmG")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorH") || playerBController.currDoor.Equals("doorH") || playerCController.currDoor.Equals("doorH")) && currRm.Equals("rmH")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorE") || playerBController.currDoor.Equals("doorE") || playerCController.currDoor.Equals("doorE")) && currRm.Equals("rmI")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorI") || playerBController.currDoor.Equals("doorI") || playerCController.currDoor.Equals("doorI")
			|| (playerAController.currDoor.Equals("doorP") || playerBController.currDoor.Equals("doorP") || playerCController.currDoor.Equals("doorP"))) && currRm.Equals("rmJ")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorJ") || playerBController.currDoor.Equals("doorJ") || playerCController.currDoor.Equals("doorJ")
			|| (playerAController.currDoor.Equals("doorP") || playerBController.currDoor.Equals("doorP") || playerCController.currDoor.Equals("doorP"))) && currRm.Equals("rmK")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorK")  || playerBController.currDoor.Equals("doorK") || playerCController.currDoor.Equals("doorK")) && currRm.Equals("rmL")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorL")  || playerBController.currDoor.Equals("doorL") || playerCController.currDoor.Equals("doorL")) && currRm.Equals("rmM")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorO")  || playerBController.currDoor.Equals("doorO") || playerCController.currDoor.Equals("doorO")) && currRm.Equals("rmN")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorL")  || playerBController.currDoor.Equals("doorL") || playerCController.currDoor.Equals("doorL")) && currRm.Equals("rmO")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorM")  || playerBController.currDoor.Equals("doorM") || playerCController.currDoor.Equals("doorM")) && currRm.Equals("rmP")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals("doorN")  || playerBController.currDoor.Equals("doorN") || playerCController.currDoor.Equals("doorN")) && currRm.Equals("rmQ")) {
			victory = true;
		}
		if ((playerAController.currDoor.Equals ("doorO")  || playerBController.currDoor.Equals("doorO") || playerCController.currDoor.Equals("doorO")) && currRm.Equals ("rmR")) {
			victory = true;
		}
	}
}
