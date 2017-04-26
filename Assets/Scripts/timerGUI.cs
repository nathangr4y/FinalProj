using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class timerGUI : MonoBehaviour {
	Image fillImg;
	float timeAmt = 30;
	float time; 

	// Use this for initialization
	void Start () {
		fillImg = this.GetComponent<Image>();
		time = 30;
	}

	// Update is called once per frame
	void Update () {
		time = countdownTimer.timer; 
		if(time  > 0){
			time -= Time.deltaTime;
			fillImg.fillAmount = time / timeAmt;
		}
	}
}