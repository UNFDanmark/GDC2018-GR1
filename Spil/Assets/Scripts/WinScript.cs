using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour {


    public int PlayersWon = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        WinScreen();
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player1") || collision.gameObject.CompareTag("player2")
        {
             PlayersWon++;

        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("player1") || collision.gameObject.CompareTag("player2") 
        {
            PlayersWon--;
        }
            
    }

    public void WinScreen()
    {
        if (PlayersWon >= 2)
        {
            SceneManager.LoadScene("Winscreen");
        }

    }
}
