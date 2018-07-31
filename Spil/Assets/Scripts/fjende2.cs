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
    public UiShitTextsomething myUi;

    public int HealthKødbolle2 = 3;
    // Use this for initialization
    void Start()
    {

        HealthKødbolle2 = 3;
    }

    // Update is called once per frame
    void Update()
    {


        if (HealthKødbolle2 <= 0)
        {
            Destroy(MyKødbolle2.gameObject);
            MyLavaScript.DeathCount++;

        }



    }
    public void OnCollisionEnter(Collision collision)
    {
        DamagePlayer2(collision);



    }


    public void PushObject(GameObject target)
    {
        Rigidbody hitRigidbody = target.GetComponent<Rigidbody>();
        Vector3 explosionDirection = hitRigidbody.transform.position - transform.position;
        explosionDirection.Normalize();
        hitRigidbody.AddForce(explosionDirection * explosionPower, ForceMode.Impulse);
    }
    
    public void DamagePlayer2(Collision collide)
    {
        if (collide.gameObject.CompareTag("player2"))
        {
            HealthKødbolle2--;
            PushObject(collide.gameObject);
            SkadeAfspiller.PlayOneShot(SkadeLyd);
            myUi.LoseHealthPlayer2();
        }
    }
}
