using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_Abyss : MonoBehaviour
{
	bool loadingStarted = false;
	float secondsLeft = 2;

	void Start()
	{
		StartCoroutine(DelayLoadLevel(2));
	}

	IEnumerator DelayLoadLevel(float seconds)
	{
		secondsLeft = seconds;
		loadingStarted = true;
		do
		{
			yield return new WaitForSeconds(1);
		} while (--secondsLeft > 0);

		Application.LoadLevel("besdna old home");
	}


}