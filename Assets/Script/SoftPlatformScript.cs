using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftPlatformScript : MonoBehaviour {

	private float useSpeed;
	public float directionSpeed =9f;
	float origx;
	public float distance = 10.0f;

	// Use this for initialization
	void Start ()
	{
		origx = transform.position.x;
		useSpeed = -directionSpeed;
	}

	// Update is called once per frame
	void Update ()
	{
		if(origx - transform.position.x > distance)
		{
			useSpeed = directionSpeed; //flip direction
		}
		else if(origx - transform.position.x < -distance)
		{
			useSpeed = -directionSpeed; //flip direction
		}
		transform.Translate(useSpeed*Time.deltaTime,0,0);
	}


	void OnCollisionEnter2D(Collision2D col){
		MakeChild ();
	}

	void OnCollisionExit2D(Collision2D col){
		ReleaseChild ();
	}

	void MakeChild(){
		Player.instance.transform.parent = this.transform;
	}


	void ReleaseChild(){
		Player.instance.transform.parent = null;
	}
}
