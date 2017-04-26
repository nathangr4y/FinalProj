using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountObjects : MonoBehaviour {

	public string nextLevel;
	public GameObject timePickup;
	private GameObject objUI;

	void Start () {
		objUI = GameObject.Find ("Hourglass");
	}
	
	// Update is called once per frame
	void Update () {
		objUI.GetComponent<Text>().text = ObjectsCollected.objects.ToString (); 
		if (ObjectsCollected.objects == 0) {
			objUI.GetComponent<Text> ().text = "No additional time left!";
		}
	}
}
