using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleAC : MonoBehaviour {

    // Use this for initialization
   public bool walking;
    public bool takingFlight;
    Animator anim;
    public float speed;
    public Transform player;
    public float rotationSpeed;
    public bool flying;
       

    void Start () {
        anim = gameObject.GetComponent<Animator>();
        

		
	}

    
    void Update()
    {

        transform.Rotate(player.right, -Input.GetAxis("Mouse Y") * rotationSpeed);
        transform.Rotate(player.up, Input.GetAxis("Mouse X") * rotationSpeed);



        if (Input.GetKey("w"))
        {
            flying = true;
            transform.Translate(speed * Vector3.forward * Time.deltaTime);

        }
        else

        {
            flying = false;
        }


        if (flying == true)
        {
            anim.SetBool("Flying", true);
        }
        else
        {
            anim.SetBool("Flying", false);
        }



        if (takingFlight == true)
        {
            anim.SetBool("TakingFlight", true);
        }


            if (Input.GetMouseButton(1))
        {

               takingFlight = true;


        }
        else
        {
            takingFlight = false;
        }



        if (Input.GetMouseButton(0))
        {
            
            walking = true;
        }

        else { walking = false;
        }

        if (walking == true)
        {
            anim.SetBool("EagleIsWalking", true);

            transform.Translate(speed * Vector3.forward * Time.deltaTime);
        }

        if (walking == false)
        {
            anim.SetBool("EagleIsWalking", false);
        }

      

    }

}
