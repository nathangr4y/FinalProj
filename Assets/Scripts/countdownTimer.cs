using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class countdownTimer : MonoBehaviour {

	public string levelLoad;
	public static float timer = 30f;
	private Text timerSeconds;
	public static bool defeat = false;

	// Use this for initialization
	void Start () {
		timerSeconds = GetComponent<Text> ();	
	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		timerSeconds.text = timer.ToString ("f2");
		if (timer <= 0) {
			defeat = true;
		}

		if (defeat){
			timerSeconds.text = "YOU LOST!";
		}

		if (gameManager.victory) {
			timerSeconds.text = "YOU WON!";
		}

	}
}
