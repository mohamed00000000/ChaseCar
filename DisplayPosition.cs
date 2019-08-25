using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Display position of MyCar
public class DisplayPosition : MonoBehaviour {

	public GameObject positionDisplay;
	public static int Mypos;	//Display the position of MyCar
	public int after1=0;			//if 0,my car is behind AICar01. if 1 my car is in front of AICar01
	public int after2=0;			//if 0,my car is behind AICar02. if 1 my car is in front of AICar02
	public int after3=0;			//if 0,my car is behind AICar02. if 1 my car is in front of AICar03
	public int after4=0;			//if 0,my car is behind AICar02. if 1 my car is in front of AICar04
	// Use this for initialization
	void Start(){
		Mypos=5;
	}
	
	void OnTriggerEnter(Collider other){
		//detect collision 
		if (other.tag=="Up1"){ // if detect Up1 collider .it is front of car1
			after1=1;
		}
		if (other.tag=="Up2"){// if detect Up2 collider .it is front of car2
			after2=1;
		}
		if (other.tag=="Up3"){// if detect Up3 collider .it is front of car3
			after3=1;
		}
		if (other.tag=="Up4"){// if detect Up4 collider .it is front of car4
			after4=1;
		}
		if (other.tag=="Down1"){// if detect Down1 collider .it is front of car1
			after1=0;
		}
		if (other.tag=="Down2"){// if detect Down2 collider .it is front of car2
			after2=0;
		}
		if (other.tag=="Down3"){// if detect Down2 collider .it is front of car3
			after3=0;
		}
		if (other.tag=="Down4"){// if detect Down4 collider .it is front of car4
			after4=0;
		}
		Mypos=5-after1-after2-after3-after4;//MycarPosition
		//Display position in UI text
		if (Mypos>5) {
			Mypos=5;
		}
		if (Mypos==1){
			positionDisplay.GetComponent<Text>().text="1st Place";
		}
		if (Mypos==2){
			positionDisplay.GetComponent<Text>().text="2nd Place";
		}
		if (Mypos==3){
			positionDisplay.GetComponent<Text>().text="3rd Place";
		}
		if (Mypos==4){
			positionDisplay.GetComponent<Text>().text="4th Place";
		}
		if (Mypos==5){
			positionDisplay.GetComponent<Text>().text="5th Place";
		}

	}
}
