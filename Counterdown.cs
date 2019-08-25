using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counterdown : MonoBehaviour {
	public GameObject CounterDown;
	public AudioSource GetReady;
	public AudioSource GoAudio;
	public GameObject LapTimer;
	public GameObject CarControl;
	public AudioSource LevelMusic;
	// Use this for initialization
	void Start () {
		LapTimer.SetActive(false);
		StartCoroutine(CounterDownStart());

	}

	IEnumerator CounterDownStart(){
		//delay 0.1s
		yield return new WaitForSeconds(0.1f);
		//Display "3"
		CounterDown.GetComponent<Text>().text="3";
		//GetReady.Play();
		CounterDown.SetActive(true);
		yield return new WaitForSeconds(1);	//Delay 1s
		CounterDown.SetActive(false);

		CounterDown.GetComponent<Text>().text="2";//Display "2"
		//GetReady.Play();
		CounterDown.SetActive(true);
		yield return new WaitForSeconds(1); //Delay 1s
		CounterDown.SetActive(false);

		CounterDown.GetComponent<Text>().text="1";//Display "1"
		//GetReady.Play();
		CounterDown.SetActive(true);
		yield return new WaitForSeconds(1);
		CounterDown.SetActive(false);

		CounterDown.GetComponent<Text>().text="Go";//Display "Go"
		CounterDown.SetActive(true);
		yield return new WaitForSeconds(0.1f);	//Delay 0.1s
		CounterDown.SetActive(false);

		//GoAudio.Play();						//Play 'Go' sound
		//LevelMusic.Play();					//Play 'LevelMusic'
		LapTimer.SetActive(true);
		CarControl.SetActive(true);				//enable CarMove
	}
	
}
