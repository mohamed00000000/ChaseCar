using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour {
	public GameObject MyCar;
	// Use this for initialization
	void Start () {
		//print(transform.position);
		//print(MyCar.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (ButtonOption.TrackMode==1){  //Track 1
			transform.position=new Vector3(103+(MyCar.transform.position.x-43)/2,197+(MyCar.transform.position.z-164)/2,0);	
		}
		if (ButtonOption.TrackMode==2){		//Track 2
			transform.position=new Vector3(110+Mathf.Floor((MyCar.transform.position.x-197)/3),194+(MyCar.transform.position.z-310)/6,0);	
		}		
	}
}
