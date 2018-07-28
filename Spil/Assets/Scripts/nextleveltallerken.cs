using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextleveltallerken : MonoBehaviour {

    public Camera MyCamera;
	// Use this for initialization
	void Start () {
		
	}


    public void OnCollisionEnter(Collision collision)
    {
        MyCamera.WorldToViewportPoint(Vector3.up * 20);
           


    }



    // Update is called once per frame
    void Update () {
		
	}
}
