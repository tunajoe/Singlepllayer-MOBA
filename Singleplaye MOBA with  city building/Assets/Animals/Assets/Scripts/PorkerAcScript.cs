using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorkerAcScript : MonoBehaviour {
    public Animator anim;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update ()


    {

   
        bool isWalkingPresed = Input.GetKey("2");
        
        anim.SetBool("IsWalking", isWalkingPresed);
       


        bool isRunningPresed = Input.GetKey("1");
        anim.SetBool("IsRunning", isRunningPresed);

        bool isRollingPresed = Input.GetKey("3");
        anim.SetBool("IsRolling", isRollingPresed);


    }
}
