using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCombat : MonoBehaviour
{
    public enum HeroAttackType { Melee, Ranged};
    public HeroAttackType heroAttackType;
    public GameObject targetedEnemy;
    public float attackRange;
    public float rotataSpeedForAttack;
    
    private playerMovement moveScript;
    private Stats statsScript;
    private Animator anim;


    public bool basicAttackIdle = false;
    public bool isHeroAlive;
    public bool preformeleeAttack=true;
    public Vector3 AttackDistance;

    
    void Start()
    {
        moveScript = GetComponent<playerMovement>();
        statsScript = GetComponent<Stats>();
        anim = GetComponent<Animator>();
      
    }

    void Update()
    {
        if(targetedEnemy!= null)
        {
            if (Vector3.Distance(gameObject.transform.position, targetedEnemy.transform.transform.position) >= attackRange) 
            {
                moveScript.agent.SetDestination(targetedEnemy.transform.position+AttackDistance);
                moveScript.agent.stoppingDistance = attackRange;
                

                Quaternion rotationToLookAt = Quaternion.LookRotation(targetedEnemy.transform.position - transform.position);
                float rotationY = Mathf.SmoothDampAngle(transform.eulerAngles.y, rotationToLookAt.eulerAngles.y, ref moveScript.rotateVelocity, rotataSpeedForAttack * (Time.deltaTime * 5));
                transform.eulerAngles = new Vector3(0, rotationY, 0);
                

            }

            else
            {
                if (heroAttackType == HeroAttackType.Melee)
                {
                    if (preformeleeAttack)
                    {

                        StartCoroutine(MeleeAttackInterval());
                    }
                }
            }

        }
       
   
    }

    IEnumerator MeleeAttackInterval() 
    {
        preformeleeAttack = false;
        anim.SetBool("Basic Attack", true);

        yield return new WaitForSeconds(statsScript.attackTime / ((100 + statsScript.attackTime) * 0.01f));

        if (targetedEnemy == null) 
        {
            anim.SetBool("Basic Attack", false);
            preformeleeAttack = true;
            
        }
    }


    public void MeleeAttack() 
    {
        if (targetedEnemy != null) 
        {
            if (targetedEnemy.GetComponent<Targetable>().enemyType == Targetable.EnemyType.Minion) 
            {
                targetedEnemy.GetComponent<Stats>().health -= statsScript.attackDmg;
                
            }
        }

        preformeleeAttack = true;
    }

}


