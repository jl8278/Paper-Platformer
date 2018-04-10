using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetSignClick : MonoBehaviour {
	public GameObject Platform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		
		if (col.CompareTag ("Player")) {
		
			Platform.SetActive (true);
		}
  }

}
