using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedmeter : MonoBehaviour {
	//public GameObject SpeedDisplay;
	public float currentSpeed;	//current speed of the car
	public GameObject pointer;
	public GameObject MyCar;
	//  initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentSpeed=MyCar.GetComponent<Rigidbody>().velocity.magnitude;  //Get speed from rigidbody property
		currentSpeed*=2.23693629f;
		//display speed text
		GetComponent<Text>().text="Speed:"+Mathf.Floor(currentSpeed*100)/100+"MPH";
		//Rotate pointer
		//pointer rotates as speed changes. 
		pointer.transform.eulerAngles=new Vector3(0,0,140-(currentSpeed)*1.4f);
		
	}
}
