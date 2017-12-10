using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

	public static int player;
	public static int meteorsCount;
	public static int Gameover;
	public static int Win;

	void Start(){
		meteorsCount = FindObjectsOfType<Meteors> ().Length;
		print (meteorsCount);
	}


	public void Levelload (string name) {
		SceneManager.LoadScene (name);
	}


	public void ExitGame () {
		print ("Tried to Exit.");
		Application.Quit ();
	}


	public void LoadNextLevel () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}



}
