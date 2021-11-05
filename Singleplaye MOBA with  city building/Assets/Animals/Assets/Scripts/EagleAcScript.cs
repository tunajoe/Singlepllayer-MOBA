using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleAcScript : MonoBehaviour {

    public Animator anim;

    void Start()
        {
            anim = GetComponent<Animator>();

        }

        // Update is called once per frame
        void Update()


        {


            bool isWalkingPresed = Input.GetKey("3");

            anim.SetBool("Flying", isWalkingPresed);



            bool isRunningPresed = Input.GetKey("2");
            anim.SetBool("TakingFlight", isRunningPresed);

            bool isRollingPresed = Input.GetKey("1");
            anim.SetBool("EagleIsWalking", isRollingPresed);


        }
    }

