using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerInteraction : MonoBehaviour {

	public GameObject currentInterObj = null;
	public InteractionObject currentInterObjScript = null;
	public SoftPlatformDisappear PlatformDisappear = null;
	public Inventory inventory;
	public GameObject Door;
	public AudioSource UnlockDoor;
	public AudioSource DoorSound;

	void Update(){

		if (Input.GetButtonDown ("Interact") && currentInterObj) {

			//check to see if this object is to be stored in inventory
			if(currentInterObjScript.inventory){
				inventory.AddItem (currentInterObj);
			}


			//check to see if this object can opened
			if(currentInterObjScript.openable){
				//check to see if the object is locked
				if (currentInterObjScript.locked) {

					DoorSound.Play ();

					//check to see if we have the object needed to unlock
					//search our inventory for the item needed if found unlock object
					if (inventory.FindItem (currentInterObjScript.itemNeeded)) {

						//we found the item needed
						currentInterObjScript.locked = false;
						Debug.Log (currentInterObj.name + "was unlocked");

					} else {
						Debug.Log (currentInterObj.name + "was not unlocked");

					} 
				} else {
					//object is not locked open the object
					Debug.Log(currentInterObj.name +"is opened");
					Door.SetActive (false);
					UnlockDoor.Play ();
				}
			}
		}

	}




	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag ("Interactable")) {

			Debug.Log ("touched");
			currentInterObj = other.gameObject;
			currentInterObjScript = currentInterObj.GetComponent <InteractionObject> ();


		}

		if (other.CompareTag ("Button")) {
			currentInterObj = other.gameObject;
			other.gameObject.SetActive (true);
		}





	}


	void OnTriggerExit2D(Collider2D other){

		if (other.CompareTag ("Interactable")) {
			if (other.gameObject == currentInterObj) {

				currentInterObj = null;
			}

		}

		if (other.CompareTag ("Button")) {
			currentInterObj = null;
		
		}
	}

}
