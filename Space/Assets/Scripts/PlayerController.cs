using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour {


	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public ParticleSystem particles;
	public float thrusterForce;
	public float rotationForce;
	public Rigidbody2D rb2D;



	public Rigidbody2D rigid;

	void Start () {
		rigid = GetComponent<Rigidbody2D>();
	
	}



	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Vector3 position = this.transform.position;
			position.x--;
			this.transform.position = position;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Vector3 position = this.transform.position;
			position.x++;
			this.transform.position = position;
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Vector3 position = this.transform.position;
			position.y++;
			this.transform.position = position;
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Vector3 position = this.transform.position;
			position.y--;
			this.transform.position = position;
		}





		if (Input.GetButtonUp ("Fire1")) {
			GameObject shot = Instantiate (projectile, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);
			//shot.AddForce(shotPos.forward * shotForce);
		}
	}
}
