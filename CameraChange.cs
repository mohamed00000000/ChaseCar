using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {
	//Change CameraViewState
	public GameObject NormalCam;
	public GameObject FarCam;
	public GameObject FPCam;
	public int CamMode=0;
	
	// Update is called once per frame
	void Update () {
		//if press v change Camera mode
		if (Input.GetKeyDown("v")){
			if (CamMode>2) {
				CamMode=0;
			}
			else
			{
				CamMode+=1;
			}
			StartCoroutine(CamModeChange());
		}
	}
	IEnumerator CamModeChange(){
		yield return new WaitForSeconds(0.01f);
		if (CamMode==0){
			NormalCam.SetActive(true);
			FPCam.SetActive(false);
		}
		if (CamMode==1){
			FarCam.SetActive(true);
			NormalCam.SetActive(false);
		}
		if (CamMode==2){
			FPCam.SetActive(true);
			FarCam.SetActive(false);
		}
	}
}
