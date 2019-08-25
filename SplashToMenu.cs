using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(ToMenu());
	}
	IEnumerator ToMenu(){
		yield return new WaitForSeconds(5);
		SceneManager.LoadScene("MainMenu");
	}
	
}
