using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarTracker02 : MonoBehaviour {
//	public GameObject TheMarker02;
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
	public int trackMark02;
	
	// Update is called once per frame
	void Update () {
		if (trackMark02==0){
			transform.position=Mark01.transform.position;
			if (ButtonOption.TrackMode==1) {//In Race1 move position waypoint1 for AICar02
				transform.position+=new Vector3(0,0,10);
			}
			if (ButtonOption.TrackMode==2){//if track02 set waypoint1
				transform.position+=new Vector3(-7,0,0);
			}
		}
		if (trackMark02==1){
			transform.position=Mark02.transform.position;
			if (ButtonOption.TrackMode==2) {//In Race2 move position waypoint1
				transform.position+=new Vector3(-7,0,0);
			}
		}
		if (trackMark02==2){
			transform.position=Mark03.transform.position;
		}
		if (trackMark02==3){
			transform.position=Mark04.transform.position;
		}
		if (trackMark02==4){
			transform.position=Mark05.transform.position;
		}
		if (trackMark02==5){
			transform.position=Mark06.transform.position;
		}
		if (trackMark02==6){
			transform.position=Mark07.transform.position;
		}
		if (trackMark02==7){
			transform.position=Mark08.transform.position;
		}
		if (trackMark02==8){
			transform.position=Mark09.transform.position;
		}
		if (trackMark02==9){
			transform.position=Mark10.transform.position;
		}
		if (trackMark02==10){
			transform.position=Mark11.transform.position;
		}
		if (trackMark02==11){
			transform.position=Mark12.transform.position;
		}
		if (trackMark02==12){
			transform.position=Mark13.transform.position;
		}		
		if (trackMark02==13){
			transform.position=Mark14.transform.position;
		}
		if (trackMark02==14){
			transform.position=Mark15.transform.position;
		}
		if (trackMark02==15){
			transform.position=Mark16.transform.position;
		}
		if (trackMark02==16){
			transform.position=Mark17.transform.position;
		}
		if (trackMark02==17){
			transform.position=Mark18.transform.position;
		}
		if (trackMark02==18){
			transform.position=Mark19.transform.position;
		}
		if (trackMark02==19){
			transform.position=Mark20.transform.position;
		}
		if (trackMark02==20){
			transform.position=Mark21.transform.position;
		}
		if (trackMark02==21){
			transform.position=Mark22.transform.position;
			if (ButtonOption.TrackMode==2) {//In Race2 move position waypoint1
				transform.position+=new Vector3(-7,0,0);
			}
		}

	}

	IEnumerator OnTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "Car02"){
			this.GetComponent<BoxCollider>().enabled=false;
			trackMark02 += 1;
			if (ButtonOption.TrackMode==1){	//Race1
				if (trackMark02==13){	
					trackMark02=0;
				}	
			}
			if (ButtonOption.TrackMode==2){//Race2
				if (trackMark02==22){	
					trackMark02=0;
				}	
			}		
			yield return new WaitForSeconds (1);
			this.GetComponent<BoxCollider>().enabled=true;				
		}
	}
}
