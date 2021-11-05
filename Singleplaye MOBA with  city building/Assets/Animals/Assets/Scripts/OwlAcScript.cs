using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlAcScript : MonoBehaviour {

    public Animator anim;

    void Start()
        {
            anim = GetComponent<Animator>();

        }

    
	

	void Update () {


        bool isWalkingPresed = Input.GetKey("2");

        anim.SetBool("owlIsWalking", isWalkingPresed);



        bool isRunningPresed = Input.GetKey("1");
        anim.SetBool("owlIsJumpWalking", isRunningPresed);

        bool isRollingPresed = Input.GetKey("3");
        anim.SetBool("owlIsPecking", isRollingPresed);
    }
}
