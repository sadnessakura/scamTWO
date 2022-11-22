using System.Collections;

using UnityEngine;
using UnityEngine.UI;
public class Games : MonoBehaviour {

	public Slider slider ;
	public Text valueCount ;


	void Start () {
		
	}
	

	void Update () {

		valueCount.text = slider.value.ToString ();
		AudioListener.volume = slider.value ;
		
	}
}
