using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kødbollebevægelsesscript : MonoBehaviour {


    public float MovementSpeed = 5f;
    public float JumpSpeed = 5f;
    public int OnGround = 0;
    public Rigidbody MyRigidbody;
    public Rigidbody MyFeetRigid;
    public Rigidbody Kødbolle2;
    public Vector3 DistanceMellemKødboller;
    public Vector3 TrækImellemKødboller;
    public float StåFastVærdi = 2f;
    //public int ChekDobbelJump;



	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
     


	}

    private void FixedUpdate()
    {
        /*if (Input.GetKey (KeyCode.D))
        {
            MoveHøjre(MovementSpeed);

        } else if (Input.GetKey (KeyCode.A))
        {
            MoveHøjre(-MovementSpeed);
        }
        */
        
        MoveHøjre(MovementSpeed * Input.GetAxis("Vertical"));

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (OnGround > 0)
            {
                Jumping(JumpSpeed);

                
            }

           /* if (Input.GetKey(KeyCode.S) && OnGround > 0)
            {
                StåFast();

            }

             DistanceMellemKødboller = Kødbolle2.transform.position - MyRigidbody.transform.position;
             TrækImellemKødboller = (Kødbolle2.transform.position - MyRigidbody.transform.position) * 0.1f;
             if (DistanceMellemKødboller.magnitude > 5)
             {
                 MyRigidbody.velocity = MyRigidbody.velocity + TrækImellemKødboller;


             }
             */
        }
         

    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("player2"))
        {
            OnGround++;
        }

        /*
        if (collision.gameObject.CompareTag("ground"))
        {
            ChekDobbelJump = 1;
        }
        */
    }

    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("player2"))
        {
            OnGround--;
        }

        /*if(collision.gameObject.CompareTag("player"))
        {
            ChekDobbelJump = 0;
        }
        */
    }



    public void Jumping (float JumpHeight)
    {
        MyRigidbody.velocity = (Vector3.right * MyRigidbody.velocity.x) + (Vector3.up * JumpHeight); 

    }


    public void StåFast()
    {
        MyRigidbody.velocity = (Vector3.down * StåFastVærdi);


    }


    public void MoveHøjre(float Speed)
    {
        MyRigidbody.velocity = (Vector3.up * MyRigidbody.velocity.y) + (transform.forward * Speed);

        


    }
}
