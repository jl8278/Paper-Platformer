using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftPlatformDestory : MonoBehaviour {
	public GameObject Platform;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Player") {
			    
				Destroy(Platform);

		}


	}
}
