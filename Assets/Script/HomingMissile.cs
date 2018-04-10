using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class HomingMissile : MonoBehaviour {

	public Transform target;

	private Rigidbody2D rb;
	public float speed;

	public float rotateSpeed;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		HomingMissileMovement ();
	}


	void HomingMissileMovement(){
		Vector2 direction = ((Vector2)target.position - rb.position)*Time.deltaTime;

		direction.Normalize ();

		float rotateAmount = Vector3.Cross (direction, transform.up).z;

		rb.angularVelocity = -rotateAmount * rotateSpeed;



		rb.velocity = transform.up * speed;
	
	}
}
