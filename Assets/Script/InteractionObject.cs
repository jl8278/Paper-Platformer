using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour {

	public bool inventory;   //If true, this object can be stroed in inventory
	public bool openable;      // if true this object can be opened
	public bool locked;      // if true the object is locked
	public GameObject itemNeeded;    //item needed in order to interact with this item


	public void DoInteraction(){

		//picked up and put in inventory

		gameObject.SetActive (false);
	}

}