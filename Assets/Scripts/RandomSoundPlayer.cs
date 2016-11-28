﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomSoundPlayer : MonoBehaviour {

    private AudioSource audioSource;
    [SerializeField]
    private List<AudioClip> soundClips = new List<AudioClip>();
    [SerializeField]
    private float soundTimerDelay = 3f;
    private float soundTimer;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
        soundTimer += Time.deltaTime;

        if (soundTimer >= soundTimerDelay) {
            soundTimer = 0;
            AudioClip ranSound = soundClips[Random.Range(0, soundClips.Count)];
            audioSource.PlayOneShot(ranSound);
        }
	
	}
}
