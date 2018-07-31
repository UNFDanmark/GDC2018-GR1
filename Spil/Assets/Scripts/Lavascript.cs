using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Lavascript : MonoBehaviour {


    public AudioSource LavaLyde;
    public AudioClip LavaSkadeLyd;
    public int DeathCount = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        

        if (DeathCount >= 2)
        {
            SceneManager.LoadScene("GameOverScreen");
        }

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player1") || collision.gameObject.CompareTag("player2"))
        {

            Destroy(collision.gameObject);

            DeathCount++;
        } 
        
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("player1") || other.gameObject.CompareTag("player2"))
        {

            Destroy(other.gameObject);
            LavaLyde.PlayOneShot(LavaSkadeLyd);
            DeathCount++;

        }

        
    }

    
        
    

}


