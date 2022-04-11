using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue()
	{
		Speech.AddDialogue("0", "Hello, you must be one of the humans in fantasy world", "1");
		Speech.AddDialogue("1", "Our worlds are in great danger, We need your help!", "2");
		Speech.AddDialogue("2", "Please help us save our worlds - find tower", "3");
		Speech.AddDialogue("3", "Find powerup to jump higher before going to the next island");

		Speech.AddDialogue("4", "I see you have already gained your first ability. When you're you can head to the corrupted fantasy island - find tower.");
	}
	

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other )
	{ if(Abilities.doubleJumpEnabled)
        {
			Speech.SetDialogue("4");
		}
	else
        {
			Speech.SetDialogue("0");
		}
		
	}
}