using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockable : MonoBehaviour {

	public GameObject greenButton;
	public int cashValue;

	public void GreenUnlock(){
		greenButton.SetActive(false);
		cashValue-=100;
	}
	
	// Update is called once per frame
	void Update () {
		cashValue=GlobalCash.TotalCash;
		if (cashValue>=100){
			greenButton.GetComponent<Button>().interactable=true;
		}
	}
}
