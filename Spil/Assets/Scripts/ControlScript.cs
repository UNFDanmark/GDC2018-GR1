﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScript : MonoBehaviour {
    public Startscript ShitButTop;

 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return))
        {
            Destroy(GameObject.FindGameObjectWithTag("DestroyThis"));
            SceneManager.LoadScene("GameScreen");
        }
	}
}
