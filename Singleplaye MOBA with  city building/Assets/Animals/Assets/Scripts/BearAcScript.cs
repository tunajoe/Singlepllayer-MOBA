using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearAcScript : MonoBehaviour {
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

    }




    void Update()
    {


        bool isWalkingPresed = Input.GetKey("2");

        anim.SetBool("bearIsWalking", isWalkingPresed);



        bool isRunningPresed = Input.GetKey("1");
        anim.SetBool("bearIsJumping", isRunningPresed);

    
    }
}
