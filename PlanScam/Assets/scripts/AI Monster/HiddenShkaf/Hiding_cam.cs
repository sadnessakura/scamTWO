using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiding_cam : MonoBehaviour {


	public GameObject Player; 
	public GameObject HidingCamera; 
	public AudioClip Sound;
	public GameObject text2;


	void  Start (){
		HidingCamera.SetActive(true);
		Player.SetActive(false);
	}

	void  Update (){

		if(Input.GetMouseButtonDown(0)) 
		{
			text2.SetActive(false);
			Player.SetActive(true);
			HidingCamera.SetActive(false);
			AudioSource.PlayClipAtPoint(Sound, transform.position); 

		}
	}



}