using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputTargeting : MonoBehaviour
{
    public GameObject selectedHero;
  //  public bool heroPlayer;
    RaycastHit hit;
    void Start()
    {
        selectedHero = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
            {
                if (hit.collider.GetComponent<Targetable>() != null) 
                {
                    if (hit.collider.gameObject.GetComponent<Targetable>().enemyType == Targetable.EnemyType.Minion)
                    {
                        selectedHero.GetComponent<HeroCombat>().targetedEnemy = hit.collider.gameObject;
                        Debug.Log(hit.collider.gameObject);
                    }
                }
                        
                        
                    
               
                
                

                else if (hit.collider.gameObject.GetComponent<Targetable>()==null) 
                {
                    selectedHero.GetComponent<HeroCombat>().targetedEnemy = null;
                }
            }

        }
    }
}

