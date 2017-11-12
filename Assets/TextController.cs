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
		print (myState);
		if (myState == States.cell) {
			state_cell();
		} else if (myState == States.sheets_0) {
			state_sheets_0();
		} else if (myState == States.mirror) {
			state_mirror();
		} else if (myState == States.door_0) {
			state_door_0();
		}
	}

	void state_cell () {
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty Sheets on the bed, a Mirror on the wall, and the Door " +
					"is locked from the outside.\n\n" +
					"Press S to view Sheets\n" + 
					"Press M to view Mirror\n" +
					"Press D to view Door";

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.door_0;
		}
	}

	void state_sheets_0 () {
		text.text = "You can't believe you sleep in these things. Surely it's time " +
					"someone changed them. The pleasures of prison life I guess!\n\n" +
					"Press C to return to roaming your Cell\n"; 
		
		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.cell;
		}
	}

	void state_mirror () {

	}

	void state_door_0 () {
		text.text = "There is a button combination lock on the other side of the cell door. " +
					"Perhaps if you could get a better look at the buttons you could figure out " +
					"the combination.\n\n" +
					"Press C to return to roaming your cell";

		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.cell;
		}
	}
}
