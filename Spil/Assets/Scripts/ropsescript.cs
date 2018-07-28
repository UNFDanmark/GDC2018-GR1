using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ropsescript : MonoBehaviour {

    public Joint jointer;
    public Joint jointer2;
    public Joint jointer3;
    public Joint jointer4;
    public Joint jointer5;
    /*
    public Joint jointer6;
    public Joint jointer7;
    public Joint jointer8;
    public Joint jointer9;
    public Joint jointer10;
    public Joint jointer11;
    public Joint jointer12;
    public Joint jointer13;
    public Joint jointer14;
    */

    public Rigidbody MyRigidbody;
    public Rigidbody MyRigidbody2;
    public Rigidbody MyRigidbody3;
    public Rigidbody MyRigidbody4;
    public Rigidbody MyRigidbody5;
    /*
    public Rigidbody MyRigidbody6;
    public Rigidbody MyRigidbody7;
    public Rigidbody MyRigidbody8;
    public Rigidbody MyRigidbody9;
    public Rigidbody MyRigidbody10;
    public Rigidbody MyRigidbody11;
    public Rigidbody MyRigidbody12;
    public Rigidbody MyRigidbody13;
    public Rigidbody MyRigidbody14;
    */
    /*public Rigidbody MyRigidbody;
    public Rigidbody MyRigidbody;
    public Rigidbody MyRigidbody;
    public Rigidbody MyRigidbody;
    public Rigidbody MyRigidbody;
    public Rigidbody MyRigidbody;
    */


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        jointer.anchor = MyRigidbody.transform.position;
        jointer2.anchor = MyRigidbody2.transform.position;
        jointer3.anchor = MyRigidbody3.transform.position;
        jointer4.anchor = MyRigidbody4.transform.position;
        jointer5.anchor = MyRigidbody5.transform.position;
        //jointer6.anchor = MyRigidbody6.transform.position;
        /*
        jointer7.anchor = MyRigidbody7.transform.position;
        jointer8.anchor = MyRigidbody8.transform.position;
        jointer9.anchor = MyRigidbody9.transform.position;
        jointer10.anchor = MyRigidbody10.transform.position;
        jointer11.anchor = MyRigidbody11.transform.position;
        jointer12.anchor = MyRigidbody12.transform.position;
        jointer13.anchor = MyRigidbody13.transform.position;
        jointer14.anchor = MyRigidbody14.transform.position;
        */
        //jointer4.anchor = MyRigidbody.transform.position;
        //jointer4.anchor = MyRigidbody.transform.position;
        //jointer4.anchor = MyRigidbody.transform.position;
        //jointer4.anchor = MyRigidbody.transform.position;
        //jointer4.anchor = MyRigidbody.transform.position;
        //jointer4.anchor = MyRigidbody.transform.position;
        //jointer4.anchor = MyRigidbody.transform.position;
        //jointer4.anchor = MyRigidbody.transform.position;



    }
}
