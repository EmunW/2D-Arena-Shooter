﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

	public static AudioClip fireSound;
	static AudioSource audioSrc;
	// Use this for initialization
	void Start () {
		fireSound = Resources.Load<AudioClip> ("Laser");
		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound(string clip){
		switch(clip){
			case "Laser":
				audioSrc.PlayOneShot(fireSound);
				break;
		}
	}
}
