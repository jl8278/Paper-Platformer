﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	public GameObject Player;       
	public float speed;
	 
	// Use this for initialization
	void Start () 
	{
		

	}

	// LateUpdate is called after Update each frame
	void Update () {
		if (Player != null) {
			float interpolation = speed * Time.deltaTime;

			Vector3 position = this.transform.position;
			position.y = Mathf.Lerp (this.transform.position.y, Player.transform.position.y, interpolation);
			position.x = Mathf.Lerp (this.transform.position.x, Player.transform.position.x, interpolation);

			this.transform.position = position;
		}
	}
}