using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Lavascript : MonoBehaviour {

    public Rigidbody Lava;
    public float LavaRising = 0.2f;
    public int DeathCount = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 ShitFuck = Lava.transform.position;
        Lava.transform.position = Lava.transform.position + Vector3.up * LavaRising * Time.deltaTime;

        if (DeathCount >= 2)
        {
            SceneManager.LoadScene("GameOverScreen");
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("player"))
        {

            Destroy(other.gameObject);

            DeathCount++;

        }

        
    }

    
        
    

}


