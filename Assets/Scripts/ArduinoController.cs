/** 
 * EXAMPLE CODE 
http://answers.unity3d.com/questions/179311/unity-to-arduino.html
http://www.dyadica.co.uk/unity3d-serialport-script/
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System;

public class ArduinoController : MonoBehaviour {

	// SerialPortConnectorMac portConnect;
	public static SerialPort sp;
	public static string strIn;
	public static List<string> portList;
	public float smooth = 2.0F;
	private Vector3 prevPosition;

	public Rigidbody testCube;
	public int speed;
	public static bool moveUp = false;
	public static bool moveDown = false;
	public static bool moveLeft = false;
	public static bool moveRight = false;
	public static bool atCenter = true;
	public static bool buttonDown = false;
	public static float xInput = 0.0f;
	public static float zInput = 0.0f;

	void Start () {

		//Debug.Log (System.IO.Ports.SerialPort.GetPortNames ().Length);
		foreach (string p in System.IO.Ports.SerialPort.GetPortNames()) {
			//Debug.Log (p);
		}

		sp = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);

		OpenConnection();
	}

	//Function connecting to Arduino
	public void OpenConnection() 
	{
		if (sp != null) 
		{
			if (sp.IsOpen) 
			{
				sp.Close();
				Debug.Log( "Closing port, because it was already open!");
			}
			else 
			{
				sp.Open();  // opens the connection
				sp.ReadTimeout = 50;  // sets the timeout value before reporting error
				//Debug.Log("Port Opened!");
			}
		}
		else 
		{
			print ("IS NULL");
			if (sp.IsOpen)
			{
				print("Port is already open");
			}
			else 
			{
				print("Port == null");
			}
		}
	}

	// Update is called once per frame
	void Update () {
		if (sp != null) {
			try{
				//Read incoming data
				strIn = sp.ReadLine ();
				if(! string.IsNullOrEmpty(strIn)){
					// Split string into an array
					//print(strIn);
					if(String.Equals(strIn," Button1")){
						buttonDown = true;
					} else {
						string[] arduinoData = strIn.Split(' ');
						buttonDown = false;
						MoveObject(arduinoData);
					}
				}
			}
			catch(Exception ex){
				// Do nothing - just ignore	
			}
		}

	}

	void OnApplicationQuit() 
	{
		sp.Close();
	}

	void GetControllerComponents(string[] arduinoData){
		
	}

	void MoveObject(string[] arduinoData){
		xInput = float.Parse (arduinoData [3]) / 10000;
		zInput = float.Parse (arduinoData [7]) / 10000;

		if (xInput >= -1.8f && xInput <= 1.8f && zInput >= -1.8f && zInput <= 1.8f) {
			atCenter = true;
		}

		//print ("xInput: " + xInput + " zInput: " + zInput);

		if (atCenter == true) {
			if (xInput > 1.9f) {
				print ("HIT UP");
				moveUp = true;
				atCenter = false;
			}
			if (xInput < -1.9f) {
				print ("HIT DOWN");
				moveDown = true;
				atCenter = false;
			}
			if (zInput > 1.9f) {
				print ("HIT LEFT");
				moveLeft = true;
				atCenter = false;
			}
			if (zInput < -1.9f) {
				print ("HIT RIGHT");
				moveRight = true;
				atCenter = false;
			}
		}
	}


	public bool IsNumber(string s) {
		bool value = true;
		foreach(char c in s.ToCharArray()) {
			value = value && char.IsDigit(c);
		}
		return value;
	}

}

