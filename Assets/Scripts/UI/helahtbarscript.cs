using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpBarSetUp : MonoBehaviour
{
    Image JumpBar;
    float maxCool = 100f; //the max amount of health
    public static float CoolDown;

    // Start is called before the first frame update
    void Start()
    {
        JumpBar = GetComponent<Image>(); //displays the healthbar image
    CoolDown = maxCool; 
    }

    // Update is called once per frame
    void Update()
    {
        JumpBar.fillAmount = CoolDown / maxCool; //health divided by the max amount you can have
    }
}