using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointerTrigger : MonoBehaviour {

	public GameObject LapCompleteTrigger;
	public GameObject HalfLapTrigger;

	void OnTriggerEnter(Collider other){
		//if MyCar collide with halfpointerTrigger
		if (other.tag=="MyCar"){
			LapCompleteTrigger.SetActive(true);
			HalfLapTrigger.SetActive(false);
		}
	}

}
