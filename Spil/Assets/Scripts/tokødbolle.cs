using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tokødbolle : MonoBehaviour {

    public float MovementSpeed = 5f;
    public float JumpSpeed = 5f;
    public int OnGround = 0;
    public Rigidbody MyRigidbody;
    public Rigidbody MyFeetRigid;
    public Rigidbody Kødbolle1;
    public Vector3 DistanceMellemKødboller;
    public Vector3 TrækImellemKødboller;
    public float StartMass = 2f;
    public float StåFastVærdi;
    //public Joint jointer4;
    



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
        

        MoveHøjre(MovementSpeed * Input.GetAxis("Horizontal"));

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            if (OnGround > 0)
            {
                Jumping(JumpSpeed);

               
            }
              
        }

        /*if (Input.GetKey(KeyCode.DownArrow) && OnGround > 0)
        {
            StåFast();

        }
        */
        
        




        //jointer4.anchor = MyRigidbody.transform.position;


        /*DistanceMellemKødboller = Kødbolle1.transform.position - MyRigidbody.transform.position;
        TrækImellemKødboller = (Kødbolle1.transform.position - MyRigidbody.transform.position) * 0.1f;
        if (DistanceMellemKødboller.magnitude > 5)
        {
            MyRigidbody.velocity = MyRigidbody.velocity - Vector3.Dot(MyRigidbody.velocity, DistanceMellemKødboller.normalized) * DistanceMellemKødboller.


        }
        */

    }
    
    public void OnTriggerEnter(Collider collision)
    {

         //if (collision.collider.tag == "Platform" || collision.collider.tag == "Player")
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("player1") )
        {
            OnGround++;
        }
         
        
        

         

        


    }

    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("player1"))
        {
             OnGround--;
        }
            
    }


    public void Jumping(float JumpHeight)
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
