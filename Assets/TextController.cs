using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States 
	{
		cell,
		sheets_0,
		mirror,
		door_0,
		sheets_1, cell_mirror,
		door_1,
		corridor_0,
		stairs_0,
		floor,
		closet_door,
		stairs_1,
		corridor_1,
		in_closet,
		corridor_2,
		corridor_3,
		courtyard
	};

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
		else if (myState == States.corridor_0)	{ state_corridor_0(); }
		else if (myState == States.stairs_0)	{ state_stairs_0(); }
		else if (myState == States.floor)		{ state_floor(); }
		else if (myState == States.closet_door)	{ state_closet_door(); }
		else if (myState == States.stairs_1)	{ state_stairs_1(); }
		else if (myState == States.corridor_1)	{ state_corridor_1(); }
		else if (myState == States.in_closet)	{ state_in_closet(); }
		else if (myState == States.corridor_2)	{ state_corridor_2(); }
		else if (myState == States.courtyard)	{ state_courtyard(); }
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
		
		if (Input.GetKeyDown (KeyCode.O))		{ myState = States.corridor_0; }
		else if (Input.GetKeyDown (KeyCode.C))	{ myState = States.cell_mirror; }
	}
	
	void state_corridor_0 () {
		text.text = "You push against the gate and it gives. You find yourself in a corridor. " +
					"After having a look around, you see a staircase, a door, and note that the " +
					"floor is a bit messy.\n\n" +
		
					"Press S to go up the Stairs\n" +
					"Press F to inspect the Floor\n" +
					"Press D to go through the Door";
		
		if		(Input.GetKeyDown (KeyCode.S))		{ myState = States.stairs_0; }
		else if (Input.GetKeyDown (KeyCode.F))		{ myState = States.floor; }
		else if (Input.GetKeyDown (KeyCode.D))		{ myState = States.closet_door; }
	}

	void state_stairs_0 () {
		text.text = "You move to the base of the stairs. You can hear voices echoing down " +
					"the stairwell. You would be recognized as an escapee immediately if you " +
					"ran into anyone. Perhaps it would be best to look around a bit more first.\n\n" +
			
					"Press C to return to looking around the Corridor";
		
		if (Input.GetKeyDown (KeyCode.C))		{ myState = States.corridor_0; }
	}
	
	void state_floor () {
		text.text = "Among the debris on the dirty floor, you spot a hairclip. " +
					"It might come in handy.\n\n" +
			
					"Press H to pick up the Hairclip";
		
		if (Input.GetKeyDown (KeyCode.H))		{ myState = States.corridor_1; }
	}

	void state_closet_door () {
		text.text = "The door is locked tight and you have no key.\n\n" +
			
					"Press C to continue looking around the Corridor";
		
		if (Input.GetKeyDown (KeyCode.C))		{ myState = States.corridor_0; }
	}

	void state_corridor_1 () {
		text.text = "Hairclip in pocket, you continue to analyze the corridor.\n\n" +
			
					"Press S to go up the Stairs\n" +
					"Press D to go through the Door";
		
		if		(Input.GetKeyDown (KeyCode.S))		{ myState = States.stairs_1; }
		else if (Input.GetKeyDown (KeyCode.D))		{ myState = States.in_closet; }
	}

	void state_stairs_1 () {
		text.text = "You move to the base of the stairs. You can hear voices echoing down " +
					"the stairwell. You would be recognized as an escapee immediately if you " +
					"ran into anyone. Perhaps it would be best to look around a bit more first.\n\n" +
				
					"Press C to return to looking around the Corridor";
		
		if (Input.GetKeyDown (KeyCode.C))		{ myState = States.corridor_1; }
	}

	void state_in_closet () {
		text.text = "The door is locked, but you are able to use the hairpin you found " +
					"to fashion a lockpick, and open the door. The door leads to a janitor's " +
					"closet. You notice some spare uniforms that look about your size...\n\n" +
			
					"Press U to change into the janitor Uniform";
		
		if (Input.GetKeyDown (KeyCode.U))		{ myState = States.corridor_2; }
	}

	void state_corridor_2 () {
		text.text = "You change into the janitor's uniform and move back into the corridor, " +
					"the stairs are the only place left to go.\n\n" +
			
					"Press S to climb the Stairs";
		
		if (Input.GetKeyDown (KeyCode.S))		{ myState = States.courtyard; }
	}

	void state_courtyard () {
		text.text = "You steel yourself and put on a confident face. As you reach the top of the " +
					"stairs and open the doors warm sunlight hits your face. You keep your head " +
					"down and keep a steady pace while walking past the guards. Distracted by their " +
					"conversation, they hardly notice you walk by. You are FREE!\n\n" +
			
					"Press Enter to restart game";
		
		if (Input.GetKeyDown (KeyCode.Return))		{ myState = States.cell; }
	}
	
}
