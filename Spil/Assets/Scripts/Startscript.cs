﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startscript : MonoBehaviour {

    public AudioSource StartMusic;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(StartMusic);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("ControlScreen");
        }
        
            
        
	}
}
