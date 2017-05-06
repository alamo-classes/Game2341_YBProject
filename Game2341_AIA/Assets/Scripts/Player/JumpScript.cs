using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {

	public AudioSource jumpSound;


	void Start () {
		//If the player jumps, play the jump sound
		if (Input.GetKeyDown (KeyCode.Space)) {
			jumpSound.Play ();
		
		}
	}
}