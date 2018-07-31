using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour {

    public float crossfadeTime = 0.2f;
    public Animator animator;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            animator.CrossFade("Walk", crossfadeTime);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            animator.CrossFade("Jump", crossfadeTime);
        }
        else
        {
            animator.CrossFade("Idle", crossfadeTime);
        }
    }
}
