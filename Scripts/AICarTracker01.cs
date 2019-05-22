using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AICarTracker01 : MonoBehaviour {
	public GameObject TheMarker01;
	public GameObject Mark01;
	public GameObject Mark02;
	public GameObject Mark03;
	public GameObject Mark04;
	public GameObject Mark05;
	public GameObject Mark06;
	public GameObject Mark07;
	public GameObject Mark08;
	public GameObject Mark09;
	public GameObject Mark10;
	public GameObject Mark11;
	public GameObject Mark12;
	public GameObject Mark13;
	public GameObject Mark14;
	public GameObject Mark15;
	public GameObject Mark16;
	public GameObject Mark17;
	public GameObject Mark18;
	public GameObject Mark19;
	public GameObject Mark20;
	public GameObject Mark21;
	public GameObject Mark22;
	
	public int trackMark01;
	
	// Update is called once per frame
	void Update () {
		if (trackMark01==0){
			transform.position=Mark01.transform.position;
			if (ButtonOption.TrackMode==1) {//In Race1 move position waypoint1 for AICar01
				transform.position+=new Vector3(0,0,0);
			}
			if (ButtonOption.TrackMode==2) {//In Race2 move position waypoint1 for AICar01
				transform.position+=new Vector3(-4,0,0);
			}
		}
		if (trackMark01==1){
			transform.position=Mark02.transform.position;
			if (ButtonOption.TrackMode==2) {//In Race2 move position waypoint1
				transform.position+=new Vector3(-4,0,0);
			}
		}
		if (trackMark01==2){
			transform.position=Mark03.transform.position;
		}
		if (trackMark01==3){
			transform.position=Mark04.transform.position;
		}
		if (trackMark01==4){
			transform.position=Mark05.transform.position;
		}
		if (trackMark01==5){
			transform.position=Mark06.transform.position;
		}
		if (trackMark01==6){
			transform.position=Mark07.transform.position;
		}
		if (trackMark01==7){
			transform.position=Mark08.transform.position;
		}
		if (trackMark01==8){
			transform.position=Mark09.transform.position;
		}
		if (trackMark01==9){
			transform.position=Mark10.transform.position;
		}
		if (trackMark01==10){
			transform.position=Mark11.transform.position;
		}
		if (trackMark01==11){
			transform.position=Mark12.transform.position;
		}
		if (trackMark01==12){
			transform.position=Mark13.transform.position;
		}		
		if (trackMark01==13){
			transform.position=Mark14.transform.position;
		}
		if (trackMark01==14){
			transform.position=Mark15.transform.position;
		}
		if (trackMark01==15){
			transform.position=Mark16.transform.position;
		}
		if (trackMark01==16){
			transform.position=Mark17.transform.position;
		}
		if (trackMark01==17){
			transform.position=Mark18.transform.position;
		}
		if (trackMark01==18){
			transform.position=Mark19.transform.position;
		}
		if (trackMark01==19){
			transform.position=Mark20.transform.position;
		}
		if (trackMark01==20){
			transform.position=Mark21.transform.position;
		}
		if (trackMark01==21){
			transform.position=Mark22.transform.position;
			if (ButtonOption.TrackMode==2) {//In Race2 move position waypoint1
				transform.position+=new Vector3(-4,0,0);
			}
		}
	}

	IEnumerator OnTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "Car01"){
			this.GetComponent<BoxCollider>().enabled=false;
			trackMark01 += 1;
			if (ButtonOption.TrackMode==1){	//Race1
				if (trackMark01==13){	
					trackMark01=0;
				}	
			}
			if (ButtonOption.TrackMode==2){//Race2
				if (trackMark01==22){	
					trackMark01=0;
				}	
			}	
			yield return new WaitForSeconds (1);
			this.GetComponent<BoxCollider>().enabled=true;				
		}
	}
}
