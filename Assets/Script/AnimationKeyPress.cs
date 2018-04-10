using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class AnimationKeyPress : MonoBehaviour {


	public AudioSource Walk;
	public AudioSource Jumping;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (Input.GetKey(KeyCode.A))
	{
			GetComponent<Animator>().SetBool("iswalkornot",true);
			Walk.Play();

	}
		if (Input.GetKey(KeyCode.D))
		{
			GetComponent<Animator>().SetBool("iswalkornot",true);
			Walk.Play();
		}

		if (!Input.GetKey (KeyCode.A) && !Input.GetKey (KeyCode.D)) {
			GetComponent<Animator> ().SetBool ("iswalkornot", false);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Animator> ().SetBool ("isjumpornot", true);

			Jumping.Play ();

		}
		if (!Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Animator> ().SetBool ("isjumpornot", false);
		}
	}
}
