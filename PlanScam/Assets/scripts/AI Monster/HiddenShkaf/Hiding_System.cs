using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiding_System : MonoBehaviour
{
	
	public GameObject Player; 
	public GameObject HidingCamera; 
	public AudioClip Sound;
	public GameObject text;
	public GameObject text2;
	bool  activateTrigger = false; 

	void  Start (){
		text.SetActive(false);	//Disabels the text.
		text2.SetActive(false);
		HidingCamera.SetActive(false);	//Disabels the the item in camera.
		Player.SetActive(true);	//turns on the item on the ground.
		activateTrigger = false;	//Activates the Trigger 
	}


	void  OnTriggerExit ( Collider Col  ){
		if(Col.tag =="Player")
		{
			activateTrigger = false;	//Disables the Trigger 
			text.SetActive(false);
		}
	}

	void  OnTriggerEnter ( Collider Col  ){
		if(Col.tag =="Player")
		{
			activateTrigger = true;
			text.SetActive(true);

			if(Input.GetMouseButtonDown(0))
			{
				activateTrigger = true;
				text.SetActive(false);
			}
		}
	}

	void  Update (){
		if (activateTrigger && Input.GetMouseButtonDown(0))
		{
			HidingCamera.SetActive(true); 
			Player.SetActive(false);
			activateTrigger = false;
			text.SetActive(false);
			text2.SetActive(true);
			AudioSource.PlayClipAtPoint(Sound, transform.position); 

		}
	}



}