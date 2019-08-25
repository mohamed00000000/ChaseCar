	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;
	using UnityEngine.SceneManagement;
	using UnityStandardAssets.Vehicles.Car;

	public class LapComplete : MonoBehaviour {

		public GameObject LapCompleteTrigger;
		public GameObject HalfLapTrigger;

		public GameObject MinuteDisplay;
		public GameObject SecondDisplay;
		public GameObject MilliDisplay;

		public GameObject CarControl;
		public GameObject AICar01;
		public GameObject AICar02;
		public GameObject AICar03;
		public GameObject AICar04;

		public GameObject LapCounter;
		public GameObject Text;
		public int LapDone;
		public static int LapMax=2;

		public float RawTime;
		//public GameObject RaceFinish;
		
		IEnumerator OnTriggerEnter(Collider other){
			if (other.tag=="MyCar"){
				LapDone+=1; //increase lapcount
				if (LapDone==LapMax){
					//RaceFinish.SetActive(true);
					//Game Finished. Disable all cars				
					CarControl.GetComponent<CarController>().enabled=false;
					CarControl.GetComponent<CarUserControl>().enabled=false;
					//Set AICar disable, let them stop
					AICar01.GetComponent<CarAIControl>().enabled=false;	
					AICar01.GetComponent<CarController>().enabled=false;	
					AICar02.GetComponent<CarAIControl>().enabled=false;	
					AICar02.GetComponent<CarController>().enabled=false;	
					AICar03.GetComponent<CarAIControl>().enabled=false;	
					AICar03.GetComponent<CarController>().enabled=false;	
					AICar04.GetComponent<CarAIControl>().enabled=false;	
					AICar04.GetComponent<CarController>().enabled=false;	
					//Display "Congratulations" and return to setting scene
					Text.GetComponent<Text>().text="Congratulations! Your racing has finished";
					LapCounter.GetComponent<Text>().text=""+LapDone;//Displays Laps
					yield return new WaitForSeconds(3);
					SceneManager.LoadScene("Setting");
				}
				/*
				if (LapTimeManager.SecondCount<=9){
					SecondDisplay.GetComponent<Text>().text="0"+LapTimeManager.SecondCount+".";
				}
				else{
					SecondDisplay.GetComponent<Text>().text=""+LapTimeManager.SecondCount+".";
				}

				if (LapTimeManager.MinuteCount<=9){
					MinuteDisplay.GetComponent<Text>().text="0"+LapTimeManager.MinuteCount+".";
				}
				else{
					MinuteDisplay.GetComponent<Text>().text=""+LapTimeManager.MinuteCount+".";
				}

				MilliDisplay.GetComponent<Text>().text=""+LapTimeManager.MilliDisplay;

				//Save time settings
				PlayerPrefs.SetInt("MinSave",LapTimeManager.MinuteCount);
				PlayerPrefs.SetInt("SecSave",LapTimeManager.SecondCount);
				PlayerPrefs.SetFloat("MiliSave",LapTimeManager.MilliCount);

				LapTimeManager.MinuteCount=0;
				LapTimeManager.SecondCount=0;
				LapTimeManager.MilliCount=0;
				*/
				LapCounter.GetComponent<Text>().text=""+LapDone;//Displays Laps
				HalfLapTrigger.SetActive(true);					//Enable HalfLapTrigger
				LapCompleteTrigger.SetActive(false);			//Disble LapCompleteTrigger
			}
		}		
}
