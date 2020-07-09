﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HandWasher : MonoBehaviour
{
    public bool InZone;
    //private bool Entered;
    private float WashTimer;
    public float RequiredTime;
    public Image BubbleBar;
    public AudioSource myFx;
    public AudioClip Faucet;
    //float MaxBubble = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InZone = false;  
    }

    public void OnMouseOver()
    {
        InZone = true;
       // Entered = true;
        myFx.PlayOneShot(Faucet);
        Debug.Log("Ur in da zone!");
    }

    public void OnMouseExit()
    {
        InZone = false;
        myFx.Pause();
        Debug.Log("Ur Out of da zone!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(WashTimer);
        if (InZone)
        {
           
            WashTimer += Time.deltaTime;
            if (WashTimer >= RequiredTime)
            {
                SceneManager.LoadScene("MainMenu");
                 Debug.Log("You Wshed ur hands!");

            }
        }
        if (!InZone)
        {

           
            WashTimer -= Time.deltaTime;
            if (WashTimer <= 0)
            {
                WashTimer = 0;

            }
        }
        BubbleBar.fillAmount = WashTimer / RequiredTime;
    }
}
