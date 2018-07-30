using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fjende2 : MonoBehaviour {
    public Lavascript MyLavaScript;
    public tokødbolle MyKødbolle2;
    public float explosionRadius;
    public float explosionPower;
    public AudioSource SkadeAfspiller;
    public AudioClip SkadeLyd;

    public int HealthKødbolle2 = 3;
    // Use this for initialization
    void Start()
    {

        HealthKødbolle2 = 3;
    }

    // Update is called once per frame
    void Update()
    {


        if (HealthKødbolle2 == 0)
        {
            Destroy(MyKødbolle2.gameObject);
            MyLavaScript.DeathCount++;

        }



    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player2"))
        {
            HealthKødbolle2--;
            PushObject(collision.gameObject);
            SkadeAfspiller.PlayOneShot(SkadeLyd);
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
