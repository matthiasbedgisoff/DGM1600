using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerups : MonoBehaviour {

	public enum Type {fancyFeast, shield, speedBoosterGoWayFast};
	public Type powerupType;
	public Sprite[] images;


	// Use this for initialization
	void Start () {
		switch (powerupType) {
		case Type.fancyFeast:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [0];
			break;
		}
		
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("We hit a powerup");


		if (powerupType == Type.speedBoosterGoWayFast) {
		}

		switch (powerupType) {
		case Type.speedBoosterGoWayFast: 
			other.GetComponent<PlayerController> ().thrusterForce *= 2;
			break;

		case Type.fancyFeast:

			break;
		case Type.shield:

			break;
		default:
			break;

		}


	
		Destroy (this.gameObject);
	}


}
