using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMusicTrigger : MonoBehaviour {

	public AudioClip EnemySound;
	public float volume;
	AudioSource audio;
	public bool alreadyPlayed = false;
	// Use this for initialization
	void Start () {

		audio = GetComponent<AudioSource> ();

	}


	// Update is called once per frame
	void OnTriggerEnter()
	{
		if (!alreadyPlayed) {
			audio.PlayOneShot (EnemySound, volume);
			alreadyPlayed = true;
		}
		
	}
}
