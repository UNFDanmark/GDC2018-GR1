using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ståfuckingstille : MonoBehaviour {

    public Rigidbody MyRigidbody;
    public Vector3 cameraPosition;
    public GameObject Player;
    public float PlayerY;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LateUpdate()
    {
        cameraPosition = new Vector3(31f, PlayerY, 1.7f);
        transform.position = cameraPosition;


        PlayerY = Player.transform.position.y;
    }
}
