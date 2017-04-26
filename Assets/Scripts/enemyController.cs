using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

	public Rigidbody enemy;
	public static Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = false;
	}

	// Update is called once per frame
	void Update () {

	}
}

