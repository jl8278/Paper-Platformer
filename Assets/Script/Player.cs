using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;



public class Player : MonoBehaviour {

	public Rigidbody2D playerRB;
	public float movementMultiplier=5f;
	public float jumpMultiplier = 2f;
	public float fallMultiplier = 2f;
	public float walkingMultiplier = 2f;
	public float JumpCount = 2;
	private float MaxJump = 2;

	public static Player instance;

	public AudioSource CatMeow;
	public AudioSource playerDestroyed;
	public Text winText;




	// Use this for initialization

	void Awake(){
		instance = this;
	}

	void Start () {
		playerRB = GetComponent<Rigidbody2D> ();
		JumpCount = MaxJump;

	}

	// Update is called once per frame
	void FixedUpdate () {
		float horizontalMovement = Input.GetAxis ("Horizontal");


			
		



		playerRB.velocity = new Vector2 (horizontalMovement * walkingMultiplier, playerRB.velocity.y);

		if (Input.GetButtonDown ("Jump")) {



			if (JumpCount >= 0) {
				JumpCount = JumpCount - 1;
				Jump ();
			} 

		}
	}


	void OnCollisionEnter2D(Collision2D other ){


		if (other.gameObject.tag == "Dog") {
		
			Destroy (this.gameObject);
			playerDestroyed.Play ();
		}



		if (other.gameObject.tag == "HardFloor" ) {
			JumpCount = MaxJump;

		}
		if (other.gameObject.tag == "SoftPlatform" ) {
			JumpCount = MaxJump;



		}
		if (other.gameObject.tag == "HighPlatform" ) {
			JumpCount = MaxJump ;
			winText.text = "You Win!";
		}
	}

	void OnTriggerEnter2D(Collider2D col){

		if(col.CompareTag("SoundTrigger")){
			CatMeow.Play();
		}
	
	}


	void Jump(){
			playerRB.velocity = Vector2.up * movementMultiplier;
		

		if (playerRB.velocity.y < 0) {//player is falling down
			//add to the existing velocity and multiply by gravity and multiply by time since
			playerRB.velocity = playerRB.velocity + Vector2.up *Physics2D.gravity.y*fallMultiplier*Time.fixedDeltaTime;

		} else if (playerRB.velocity.y > 0) {//player is jumping up
			playerRB.velocity = playerRB.velocity + Vector2.up *Physics2D.gravity.y*jumpMultiplier*Time.fixedDeltaTime;
		}
	}
}