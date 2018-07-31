using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ståfuckingstille : MonoBehaviour {

    public Rigidbody MyRigidbody;
    public Vector3 cameraPosition;
    public GameObject Player;
    public GameObject Player2;
    public float PlayerY;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        CheckExistence();

	}

    public void LateUpdate()
    {
        cameraPosition = new Vector3(31f, PlayerY, 1.7f);
        transform.position = cameraPosition;


        PlayerY = Player.transform.position.y + 5;
    }


    public void CheckExistence()
    {
        if (! GameObject.Find("Kødbolle 1 (1)"))
        {
            Player = Player2;
        }
    }
}
