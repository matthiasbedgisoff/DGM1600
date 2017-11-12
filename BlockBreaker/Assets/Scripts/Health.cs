using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int health;
	private LevelManager levelManager;

	void Start(){
		levelManager = FindObjectOfType<LevelManager> ();
	}



	void OnCollisionEnter2D (Collision2D myCollider) {

		//Take away health
		health--;
		//if health is < 0 destroy brick
		if (health <= 0) {
			LevelManager.brickCount--;
			Destroy (this.gameObject);
			levelManager.CheckBrickCount ();
		}

	}
}
