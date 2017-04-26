﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsCollected : MonoBehaviour {

	public static int objects = 0;

	void Awake () {
		objects++;
	}
	
	void OnTriggerEnter (Collider player) {
		if (player.gameObject.tag == "Player") 
			objects--;
		gameObject.SetActive (false);
		countdownTimer.timer += 10f;
	}
}
