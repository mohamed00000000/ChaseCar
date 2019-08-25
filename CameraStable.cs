using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {
	public GameObject MyCar;
	public float CarX;
	public float CarY;
	public float CarZ;
		
	// Update is called once per frame
	void Update () {
		CarY=MyCar.transform.eulerAngles.y;
		transform.eulerAngles=new Vector3(0,CarY,0);
	}
}
