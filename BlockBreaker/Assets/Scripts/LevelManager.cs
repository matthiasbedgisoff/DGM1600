﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

	public void Levelload (string name) {
		SceneManager.LoadScene (name);
	}


	public void ExitGame () {
		print ("Tried to Exit.");
		Application.Quit ();
	}
}
