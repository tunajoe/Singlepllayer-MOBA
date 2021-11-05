using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour

{
    public Slider Enemyslider3d;
    Stats statsScript;
    void Start()
    {
        statsScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Stats>();
        Enemyslider3d.maxValue = statsScript.maxHealth;
        statsScript.health = statsScript.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Enemyslider3d.value = statsScript.health;

    }
}
