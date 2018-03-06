using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationKeyPress : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (Input.GetKey(KeyCode.A))
	{
		GetComponent<Animator>().SetBool("iswalkornot",true);
	}
		if (Input.GetKey(KeyCode.D))
		{
			GetComponent<Animator>().SetBool("iswalkornot",true);
		}

		if (!Input.GetKey (KeyCode.A) && !Input.GetKey (KeyCode.D)) {
			GetComponent<Animator> ().SetBool ("iswalkornot", false);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Animator> ().SetBool ("isjumpornot", true);
		}
		if (!Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Animator> ().SetBool ("isjumpornot", false);
		}
	}
}
