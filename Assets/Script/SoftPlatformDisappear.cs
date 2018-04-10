using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftPlatformDisappear : MonoBehaviour {
	public GameObject Platform;
	public bool hasTimeHasStarted = false;
	float CountDownTimer = 5f;



	void Update(){

		if (hasTimeHasStarted == true) {

			CountDownTimer -= Time.deltaTime;
			if (CountDownTimer <= 0) {

				PlatformDisappear ();
				hasTimeHasStarted = false;

			}

		} 
	}

	



	public void PlatformDisappear(){
		
			    
			gameObject.SetActive (false);




	}

	void OnCollisionEnter2D(Collision2D other){
		
		if(other.gameObject.CompareTag ("Player")){
			if (hasTimeHasStarted == false) {
				hasTimeHasStarted = true;
				CountDownTimer = 5f;

		}
			
		
		}

}
}
