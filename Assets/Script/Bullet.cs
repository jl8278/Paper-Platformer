using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public Transform target;
	public float ProjectileSpeed = 20;

	private Transform myTransform;

	void Awake() 
	{
		myTransform = transform; 
	}

	void Start () 
	{
		GameObject go = GameObject.FindGameObjectWithTag("Player");
		target = go.transform;

		myTransform.LookAt(target);
	}

	// Update is called once per frame
	void Update () 
	{
		BulletMovement ();
	}


	void BulletMovement(){
	
		float amtToMove = ProjectileSpeed * Time.deltaTime;

		myTransform.Translate(Vector3.forward * amtToMove);
	}
}