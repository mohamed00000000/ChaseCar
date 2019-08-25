using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour {
	//1=red, 2=Blue 3=Green
	public GameObject RedBody;
	public GameObject BlueBody;
	public GameObject GreenBody;
	public int CarImport;
	// Use this for initialization
	void Start () {
		CarImport=GlobalCar.CarType;//import which car you select
		if (CarImport==1){
			RedBody.SetActive(true);
		}
		if (CarImport==2){
			BlueBody.SetActive(true);
		}
		if (CarImport==3){
			GreenBody.SetActive(true);
		}

	}
}
