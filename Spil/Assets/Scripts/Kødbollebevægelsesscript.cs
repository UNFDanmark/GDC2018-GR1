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
    public AudioSource JumpAudioSource;
    public AudioClip JumpSound;
    public AudioClip LandingSound;
    public float crossfadeTime = 0.2f;
    public Animator animator;
    public GameObject Model;
    public Quaternion Modeldrejer;
    //public int ChekDobbelJump;



    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        WalkAnimation();
        
        


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
                animator.CrossFade("Jump", crossfadeTime);


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
            JumpAudioSource.PlayOneShot(LandingSound, 1f);

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
        JumpAudioSource.PlayOneShot(JumpSound, 1f);
        //animator.CrossFade("Jump", crossfadeTime);
    }


    public void StåFast()
    {
        MyRigidbody.velocity = (Vector3.down * StåFastVærdi);


    }


    public void MoveHøjre(float Speed)
    {
        MyRigidbody.velocity = (Vector3.up * MyRigidbody.velocity.y) + (transform.forward * Speed);
       




    }

    public void WalkAnimation()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            print("d");

            Model.transform.rotation = Quaternion.Euler(0, 0, 0);
            if (OnGround > 0)
            {
                animator.CrossFade("Walk", crossfadeTime);
            }

        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            print("a");

            Model.transform.rotation = Quaternion.Euler(0, 180, 0);
            if (OnGround > 0)
            {
                animator.CrossFade("Walk", crossfadeTime);
            }

        }
        else if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.W) && OnGround > 0)
        {
            print("stop");
            animator.CrossFade("Idle",crossfadeTime);
        }
    }
}
