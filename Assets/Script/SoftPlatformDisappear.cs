using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftPlatformDisappear : MonoBehaviour {
	public GameObject Platform;
	public bool hasTimeHasStarted = false;
	float CountDownTimer = 5f;



	void Update(){
		

	
	}


	public void PlatformDisappear(){
		
			    
			gameObject.SetActive (false);




	}

	void OnCollisionEnter2D(Collision2D other){
		
		if(gameObject.CompareTag ("Player")){
			if (hasTimeHasStarted) {
				CountDownTimer -= Time.deltaTime;
				if (CountDownTimer <= 0) {

					PlatformDisappear ();

				}

			}
		}
			
		}
	

}
