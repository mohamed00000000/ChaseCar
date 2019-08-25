using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyRot : MonoBehaviour {
	public float rotateSpeed=0.3f;
	
	//Rotate skybox	
	void Update () {
		RenderSettings.skybox.SetFloat("_Rotation",Time.time*rotateSpeed);		
	}
}
