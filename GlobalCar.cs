﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour {
	public static int CarType;//1=red, 2=blue,3=green
	public GameObject Trackwindow;

	public void RedCar(){
		CarType=1;
		Trackwindow.SetActive(true);
	}

	public void BlueCar(){
		CarType=2;
		Trackwindow.SetActive(true);
	}

	public void GreenCar(){
		CarType=3;
		Trackwindow.SetActive(true);
	}
	
}
