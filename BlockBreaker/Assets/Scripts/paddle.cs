using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour {

	public float paddleHeight;

	private Transform paddleTrans;

	void Start () {
		paddleTrans = gameObject.GetComponent<Transform> ();
	}
		
	void Update () {
		//get mouse position, translating to world coordinates
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		//Override vertical y position
		mousePos.y = paddleHeight;
		//override z depth position
		mousePos.z = 0;

		//apply transform information from mousePos
		paddleTrans.position = mousePos;
		
	}
}
