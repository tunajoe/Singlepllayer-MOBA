using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Abilities : MonoBehaviour
{
    public Image abilityImage1;
    public float cooldown = 5.0f;
    bool iscooldown = false;
    public KeyCode ability1;

    void Start()
    {
        abilityImage1.fillAmount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(ability1) && iscooldown == false)
        {
            iscooldown = true;
            abilityImage1.fillAmount = 1;
        }
        if (iscooldown) 
        {
            abilityImage1.fillAmount -= 1 / cooldown * Time.deltaTime;
            if(abilityImage1.fillAmount<=0)
            {
                abilityImage1.fillAmount = 0;
                iscooldown = false;

            }
        }
    }
}
