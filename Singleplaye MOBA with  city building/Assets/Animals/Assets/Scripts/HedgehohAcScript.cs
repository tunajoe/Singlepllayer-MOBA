using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HedgehohAcScript : MonoBehaviour {
    public Animator anim;
 
    void Start () {

        anim = GetComponent<Animator>();
    }
	

	void Update () {

        bool isRunningPresed = Input.GetKey("2");
        anim.SetBool("DadIsWalking", isRunningPresed);

        bool isRollingPresed = Input.GetKey("1");
        anim.SetBool("DadIsRolling", isRollingPresed);
    }
}
