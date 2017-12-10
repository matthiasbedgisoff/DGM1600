using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementTest : MonoBehaviour {

	public float speed;
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public ParticleSystem particles;
	public float thrusterForce;
	public float rotationForce;
	public Rigidbody2D rb2D;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
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