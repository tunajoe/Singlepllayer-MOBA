using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour


    
{
    public NavMeshAgent enemyAgent;
    public Transform playerTarget;
    public Vector3 spacing;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyAgent.SetDestination(playerTarget.transform.position+spacing);

    }
}
