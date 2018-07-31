using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fjende : MonoBehaviour {
    public Lavascript MyLavaScript;
    public Kødbollebevægelsesscript MyKødbolle1;
    public float explosionRadius;
    public float explosionPower;
    public AudioSource SkadeAfspiller;
    public AudioClip SkadeLyd;
    public UiShitTextsomething MyUi;
    public Animator animator;
    public float crossfadeTime = 0.2f;

    public int HealthKødbolle1 = 3;
	// Use this for initialization
	void Start ()
    {

          HealthKødbolle1 = 3;
        animator.CrossFade("Dance", crossfadeTime);
    }
	
	// Update is called once per frame
	void Update () {


        if (HealthKødbolle1 <= 0)
        {
            Destroy(MyKødbolle1.gameObject);
            MyLavaScript.DeathCount++;
                
        }



    }
   

    public void OnCollisionEnter (Collision collision)
    {
        DamagePlayer1(collision);


        

    }
    

    public void PushObject(GameObject target)
    {
        Rigidbody hitRigidbody = target.GetComponent<Rigidbody>();
        Vector3 explosionDirection = hitRigidbody.transform.position - transform.position;
        explosionDirection.Normalize();
        hitRigidbody.AddForce(explosionDirection * explosionPower, ForceMode.Impulse);
    }

    public void DamagePlayer1(Collision colidi)
    {
        if (colidi.gameObject.CompareTag("player1"))
        {
            HealthKødbolle1--;
            PushObject(colidi.gameObject);
            SkadeAfspiller.PlayOneShot(SkadeLyd);
            MyUi.LoseHealthPlayer1();
        }

    }

}
