using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public ParticleSystem particles;
	public GameObject health;



	void Start () {
		
	}
	

	void Update () {
		
		if (Input.GetKey (KeyCode.Space)) {
			rigid.AddRelativeForce (new Vector2 (Or, thrusterForce), ForceMode2D.Force);
			particles.Emit (1);
		} else {
			particles.Stop ();
		}

		if(Input.GetButtonUp("Fire1"))
		{
			GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);
			//shot.AddForce(shotPos.forward * shotForce);
		}


		switch (health) {
		case 1: //do this stuff; break;
		case 2:
		default:
			break;
		}






	}
}
