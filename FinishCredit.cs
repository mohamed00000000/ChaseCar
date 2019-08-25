using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishCredit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(CreditFinish());
	}
	
	IEnumerator CreditFinish(){
		//Wait for 10 Seconds
		yield return new WaitForSeconds(10);
		//Go back main menu
		SceneManager.LoadScene("MainMenu");
	}	
}