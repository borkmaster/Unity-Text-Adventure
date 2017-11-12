using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, sheets_0, mirror, door_0, sheets_1, cell_mirror, door_1, freedom};
	private States myState = States.cell;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		if 		(myState == States.cell)		{ state_cell(); }
		else if (myState == States.sheets_0) 	{ state_sheets_0(); }
		else if (myState == States.mirror) 		{ state_mirror(); }
		else if (myState == States.door_0) 		{ state_door_0(); }
		else if (myState == States.sheets_1) 	{ state_sheets_1(); }
		else if (myState == States.cell_mirror) { state_cell_mirror(); }
		else if (myState == States.door_1)		{ state_door_1(); }
		else if (myState == States.freedom)		{ state_freedom(); }
	}

	void state_cell () {
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty Sheets on the bed, a Mirror on the wall, and the Door " +
					"is locked from the outside.\n\n" +
					
					"Press S to view Sheets\n" + 
					"Press M to view Mirror\n" +
					"Press D to view Door";

		if		(Input.GetKeyDown (KeyCode.S))	{ myState = States.sheets_0; }
		else if (Input.GetKeyDown (KeyCode.M))	{ myState = States.mirror; }
		else if (Input.GetKeyDown (KeyCode.D))	{ myState = States.door_0; }
	}

	void state_sheets_0 () {
		text.text = "You can't believe you sleep in these things. Surely it's time " +
					"someone changed them. The pleasures of prison life I guess!\n\n" +
					
					"Press C to return to roaming your Cell\n"; 
		
		if (Input.GetKeyDown (KeyCode.C))		{ myState = States.cell; }
	}

	void state_mirror () {
		text.text = "The mirror on the wall seems loose.\n\n" +
		
					"Press T to return to Take the mirror\n" +
					"Press C to return to roaming your cell";
		
		if		(Input.GetKeyDown (KeyCode.T))		{ myState = States.cell_mirror; }
		else if (Input.GetKeyDown (KeyCode.C))		{ myState = States.cell; }
	}

	void state_door_0 () {
		text.text = "There is a button combination lock on the other side of the cell door. " +
					"Perhaps if you could get a better look at which buttons have been pressed recently " +
					"you could figure out the combination.\n\n" +
					
					"Press C to return to roaming your cell";

		if (Input.GetKeyDown (KeyCode.C))		{ myState = States.cell; }
	}
	
	void state_sheets_1 () {
		text.text = "Mirror in hand, you revisit the bed and dirty sheets. There doesn't seem to be anything else " +
					"you can do here for now.\n\n" +
		
					"Press C to return to roaming your cell";
		
		if (Input.GetKeyDown (KeyCode.C))		{ myState = States.cell_mirror; }
	}
	
	void state_cell_mirror () {
		text.text = "You return to observing the cell, mirror in hand.\n\n" +
		
					"Press S to view Sheets\n" + 
					"Press D to view Door";
		
		if		(Input.GetKeyDown (KeyCode.S))		{ myState = States.sheets_1; }
		else if (Input.GetKeyDown (KeyCode.D))		{ myState = States.door_1; }
	}
	
	void state_door_1 () {
		text.text = "You carefully slide the mirror through the bars and turn it around so you can see the lock. " + 
					"You can just make out dirty fingerprints on some of the buttons. After a bit of trial and error, " +
					"you hear a click.\n\n" +
					
					"Press O to open the cell door\n" +
					"Press C to return to your cell";
		
		if (Input.GetKeyDown (KeyCode.O))		{ myState = States.freedom; }
		else if (Input.GetKeyDown (KeyCode.C))	{ myState = States.cell_mirror; }
	}
	
	void state_freedom () {
		text.text = "You push against the gate and it gives. You are free!\n\n" +
		
					"Press Enter to replay";
		
		if (Input.GetKeyDown (KeyCode.Return))		{ myState = States.cell; }
	}
	
	
	
	
	
	
	
	
	
	
	
}
