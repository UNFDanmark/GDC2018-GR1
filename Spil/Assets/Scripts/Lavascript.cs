using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lavascript : MonoBehaviour {

    public Rigidbody Lava;
    public float LavaRising = 0.2f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 ShitFuck = Lava.transform.position;
        Lava.transform.position = Lava.transform.position + Vector3.up * LavaRising * Time.deltaTime;


	}

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("player"))
        {

            Destroy(other.gameObject);
        }


    }



}


