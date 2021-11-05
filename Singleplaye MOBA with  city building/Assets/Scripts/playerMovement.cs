using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class playerMovement : MonoBehaviour
{
   public NavMeshAgent agent;
    private HeroCombat heroCombatScript;
    public float rotateSpeedMovement;
    public float rotateVelocity;
    void Start()
    {
        agent=gameObject.GetComponent<NavMeshAgent>();
        heroCombatScript = GetComponent<HeroCombat>();
    }

    // Update is called once per frame
    void Update()
    {
        if (heroCombatScript.targetedEnemy != null)
        {
            if (heroCombatScript.targetedEnemy.GetComponent<HeroCombat>() != null) 
            {
                if (heroCombatScript.targetedEnemy.GetComponent<HeroCombat>().isHeroAlive)
                {
                    heroCombatScript.targetedEnemy = null;
                }

            }

        }




        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit,Mathf.Infinity)) 
            {
                if (hit.collider.tag =="floor") 
                {
                    heroCombatScript.targetedEnemy = null;
                    agent.stoppingDistance = 0;
                    agent.SetDestination(hit.point);
                    Quaternion rotationToLookAt = Quaternion.LookRotation(hit.point - transform.position);
                    float rotationY = Mathf.SmoothDampAngle(transform.eulerAngles.y,rotationToLookAt.eulerAngles.y,ref rotateVelocity,rotateSpeedMovement*(Time.deltaTime*5));
                    transform.eulerAngles = new Vector3(0, rotationY, 0);
                }
              
            }
        
        }
    }
}
