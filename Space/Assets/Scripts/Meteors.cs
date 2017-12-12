using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Meteors : MonoBehaviour {


	public float startingSpin;

//rotation of the meteors
	void Start () {
		GetComponent<Rigidbody2D>().AddTorque(Random.Range(-startingSpin,startingSpin),ForceMode2D.Impulse);
	
	
	}
	



		


}
	

