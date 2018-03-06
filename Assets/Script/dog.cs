using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog : MonoBehaviour {

	private float useSpeed;
	public float directionSpeed =9f;
	float origx;
	public float distance = 10.0f;
	public GameObject Player;
	public bool isfacingright = true;

	// Use this for initialization
	void Start ()
	{
		isfacingright =true;
		FlipDirection ();
		origx = transform.position.x;
		useSpeed = -directionSpeed;
	}

	// Update is called once per frame
	void Update ()
	{
		if(origx - transform.position.x > distance)
		{
			isfacingright = true;
			FlipDirection ();


			useSpeed = directionSpeed; 
		}
		else if(origx - transform.position.x < -distance)
		{
			isfacingright = false;
				FlipDirection();
			useSpeed = -directionSpeed; 

		}
		transform.Translate(useSpeed*Time.deltaTime,0,0);
	}


	void FlipDirection(){
		if (isfacingright == false) {
			
			Vector2 scale = transform.localScale;
			scale.x = -1 * Mathf.Abs (scale.x);
			transform.localScale = scale;

		}

		if (isfacingright == true) {
			Vector2 scale = transform.localScale;

			scale.x = 1 * Mathf.Abs (scale.x);
			transform.localScale= scale;

		}

	}

}
