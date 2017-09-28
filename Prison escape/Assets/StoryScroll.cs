using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScroll : MonoBehaviour {


	public Text textObject;

	public enum States{start, Bed, Gate, Window, Hallway, Desk, Officer, Front_Door, Outside, Car, Road};
	public States myState;

	public bool taser = false;
	public bool keys = false;


	// Use this for initialization
	void Start () {
		myState = States.start;

	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.start) {
			State_start ();
		} else if (myState == States.Bed) {
			State_Bed ();
		} else if (myState == States.Gate) {
			State_Gate ();
		} else if (myState == States.Window) {
			State_Window ();
		} else if (myState == States.Hallway) {
			State_Hallway ();
		} else if (myState == States.Desk) {
			State_Desk ();
		} else if (myState == States.Officer) {
			State_Officer ();
		} else if (myState == States.Front_Door) {
			State_Front_Door ();
		} else if (myState == States.Outside) {
			State_Outside ();
		} else if (myState == States.Car) {
			State_Car ();
		}else if (myState == States.Road) {
			State_Road ();
		}
	}

	void State_start(){
		textObject.text = "You are in a prison Cell" +
		"\nThere is a Bed" +
		"\nThere is a Gate" +
		"\nThere is a Window" +
		"\n\nPress B to go to Bed. Press G to go to Gate. Press W to go to Window";

		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.Bed;
		} else if (Input.GetKeyDown (KeyCode.G)) {
			myState = States.Gate;
		} else if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.Window;
		}
	}
	void State_Bed(){
		textObject.text = "You are by your bed" +
		"\nIt has an old sheet. Not of any good use" +
		"\n\n Press G to go to Gate. Press W to go to Window. Press s to go back to start.";

		if (Input.GetKeyDown (KeyCode.G)) {
			myState = States.Gate; 
		} else if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.Window;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.start;
		} 
	}
	void State_Gate(){
		textObject.text = "You are by your Gate" +
		"\nIt seems like the lock for the gate is weak" +
		"\n\n Press S to go to Start. Press B to go to Bed. Press W to go to Window. Press H to go to Hallway";

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.start; 
		} else if (Input.GetKeyDown (KeyCode.W)) {
			myState = States.Window;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.Bed;
		} else if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.Hallway;
		}

	}
	void State_Window(){
		textObject.text = "You are by your Window" +
		"\nIt's a dark night." +
		"\nPress S to go to start" +
		"\nPress B to go to Bed" +
		"\nPress G to go to Gate";

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.start; 
		} else if (Input.GetKeyDown (KeyCode.G)) {
			myState = States.Gate;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.Bed;
		}
	}

	void State_Hallway(){
			textObject.text = "Your in a Dark Hallway" +
				"\nPress O to go to Officer" +
				"\nPress D to go to Desk" +
				"\nPress G to go to Gate";
			if (Input.GetKeyDown (KeyCode.O)) {
				myState = States.Officer; 
			} else if (Input.GetKeyDown (KeyCode.G)) {
				myState = States.Gate;
			} else if (Input.GetKeyDown (KeyCode.D)) {
				myState = States.Desk;
			}
		}
	
	void State_Desk(){
		textObject.text = "You are by a desk" +
		"\nYou see a taser on the Desk" +
		"\nPress T to grab the Taser" +
		"\nPress H to go back to the Hallway";

		if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.Hallway;
		}
		if (Input.GetKeyDown (KeyCode.T)) {
			taser = true;
		}
	}

	void State_Officer(){
		if (taser == true) {
			textObject.text = "You use the taser and knock out the officer" +
			"\nPress K to grab Keys" +
			"\nPress F to go to Front Door";
			
		if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.Front_Door;
		}
		if (Input.GetKeyDown (KeyCode.K)) {
				keys = true;
			}
		}
		if (taser == false) {
			textObject.text = "You get caught by the officer and get thrown back to you cell" +
			"\nPress S to go back to Start";
			if (Input.GetKeyDown (KeyCode.S)) {
				myState = States.start;
			}
		}

	}


	void State_Front_Door(){
		if (keys == true) {
			textObject.text = "You use the Keys to open the door" +
			"\nPress O to go Outside";
		if (Input.GetKeyDown (KeyCode.O)) {
				myState = States.Outside;
			}
		}
		if (keys == false) {
			textObject.text = "The Door seems to be locked" +
			"\nPress O to go back to the officer";
			if (Input.GetKeyDown (KeyCode.O)) {
				myState = States.Officer;
			}
		}
	}

    void State_Outside(){
		textObject.text = "You are outside" +
		"\n You see a Car in the distance" +
		"\nPress C to get to the Car" +
		"\nPress F to go to the front door";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.Car;
		}
		if (Input.GetKeyDown (KeyCode.F)) { 
			myState = States.Front_Door;
		}

	}
		
    void State_Car(){ 
		textObject.text = "You are in The car" +
		"\n Seems like the keys have the car keys too" +
		"\n\n Press R to go to Road";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.Road;
		}
	}

   	void State_Road(){
		textObject.text = "You Won" +
		"\n\nYou have escape from prison." +
		"\nTime to head out to your next crime.";
	}


   }
	



