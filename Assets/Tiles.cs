﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour {

	public GameManager gameManager;
    public AudioClip hit;
    private AudioSource source;


	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnTriggerEnter(Collider other) {
		gameManager.AddPoint();	
        source.PlayOneShot(hit);
	}
}
