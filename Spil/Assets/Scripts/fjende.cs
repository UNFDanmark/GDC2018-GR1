using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fjende : MonoBehaviour {
    public Lavascript MyLavaScript;
    public Kødbollebevægelsesscript MyKødbolle1;
    public tokødbolle MyKødbolle2;
    public float explosionRadius;
    public float explosionPower;

    public int HealthKødbolle1 = 3;
    public int HealthKødbolle2 = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (HealthKødbolle1 >= 0)
        {
            Destroy(MyKødbolle1.gameObject);
            MyLavaScript.DeathCount++;
                
        }

        if (HealthKødbolle2 >= 0)
        {
            Destroy(MyKødbolle2.gameObject);
            MyLavaScript.DeathCount++;

        }


    }
    public void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("player1"))
        {
            HealthKødbolle1--;
            PushObject(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("player2"))
        {
            HealthKødbolle2--;
            PushObject(collision.gameObject);
        }


        

    }
    

    public void PushObject(GameObject target)
    {
        Rigidbody hitRigidbody = target.GetComponent<Rigidbody>();
        Vector3 explosionDirection = hitRigidbody.transform.position - transform.position;
        explosionDirection.Normalize();
        hitRigidbody.AddForce(explosionDirection * explosionPower, ForceMode.Impulse);
    }

}
