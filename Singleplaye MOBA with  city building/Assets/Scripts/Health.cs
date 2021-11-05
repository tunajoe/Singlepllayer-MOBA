using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour

{
    public Slider playerSlider3d;
    Slider playerSlider2d;
    Stats statsScript;
    

    void Start()
    {
        playerSlider2d = GetComponent<Slider>();

        statsScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Stats>();
        playerSlider3d.maxValue = statsScript.maxHealth;
        playerSlider2d.maxValue = statsScript.maxHealth;
        statsScript.health = statsScript.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
        playerSlider2d.value = statsScript.health;
        playerSlider3d.value = playerSlider2d.value;


    }
}
