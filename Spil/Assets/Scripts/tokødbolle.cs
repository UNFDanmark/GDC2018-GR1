using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tokødbolle : MonoBehaviour {

    public float MovementSpeed = 5f;
    public float JumpSpeed = 5f;
    public int OnGround = 0;
    public Rigidbody MyRigidbody;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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

        MoveHøjre(MovementSpeed * Input.GetAxis("Horizontal"));

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            if (OnGround == 1)
            {
                Jumping(JumpSpeed);

                OnGround = 0;
            }
            
           
          
             
                 

            
        }


    }

    public void OnCollisionEnter(Collision collision)
    {

        
        

         OnGround = 1;

        


    }
    

    public void Jumping(float JumpHeight)
    {
        MyRigidbody.velocity = (Vector3.right * MyRigidbody.velocity.x) + (Vector3.up * JumpHeight);

    }





    public void MoveHøjre(float Speed)
    {
        MyRigidbody.velocity = (Vector3.up * MyRigidbody.velocity.y) + (transform.forward * Speed);



        
    }
}
