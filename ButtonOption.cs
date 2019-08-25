using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour {
	public static int TrackMode;//1-Track1, 2-Track2
	public void PlayGame(){
		SceneManager.LoadScene("Setting");
	}
	public void Help(){
		//SceneManager.LoadScene("Setting");
	}
	public void MainMenu(){
		SceneManager.LoadScene("MainMenu");
	}
	public void Credit(){
		SceneManager.LoadScene("Credit");
	}
	public void Quit(){
		Application.Quit();
	}
	public void Track01(){
		SceneManager.LoadScene("RacingArea01");
		TrackMode=1;
	}
	public void Track02(){
		SceneManager.LoadScene("RacingArea02");
		TrackMode=2;
	}
}
