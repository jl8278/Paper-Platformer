using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftPlatformUp : MonoBehaviour {
	private float useSpeed;
	public float directionSpeed =9f;
	float origy;
	public float distance = 10.0f;


	// Use this for initialization
	void Start ()
	{
		origy = transform.position.y;
		useSpeed = -directionSpeed;
	}

	// Update is called once per frame
	void Update ()
	{
		if(origy - transform.position.y > distance)
		{
			useSpeed = directionSpeed; //flip direction
		}
		else if(origy - transform.position.y < -distance)
		{
			useSpeed = -directionSpeed; //flip direction
		}
		transform.Translate(0,useSpeed*Time.deltaTime,0);
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
