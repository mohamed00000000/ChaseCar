using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class Carcontrolactive : MonoBehaviour {
	public GameObject CarControl;
	public GameObject AICar01;
	public GameObject AICar02;
	public GameObject AICar03;
	public GameObject AICar04;
	// Use this for initialization
	void Start () {
		//Set Car ,they go
		CarControl.GetComponent<CarController>().enabled=true;
		//Set AICar enable, let them go
		AICar01.GetComponent<CarAIControl>().enabled=true;	
		AICar02.GetComponent<CarAIControl>().enabled=true;	
		AICar03.GetComponent<CarAIControl>().enabled=true;	
		AICar04.GetComponent<CarAIControl>().enabled=true;		
	}	
}
