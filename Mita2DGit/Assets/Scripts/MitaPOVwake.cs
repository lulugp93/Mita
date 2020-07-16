﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MitaPOVwake : MonoBehaviour
{
    public GameObject bothclosed;
    public GameObject Lclosed;
    public GameObject Rclosed;
    public GameObject awaken;
    public GameObject Lzone;
    public GameObject Rzone;
    public static bool IsWin = false;
    private bool Lawake;
    private bool Rawake;
    public float y1;
    public float y2;
    // Start is called before the first frame update
    void Start()
    {
        Lawake = false;
        Rawake = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (MitaLeftEyeWake.OverLeftEye)
        {
            if (Input.GetMouseButtonDown(0))
            {
                y1 = Input.mousePosition.y;
            }

            if (Input.GetMouseButtonUp(0))
            {
                y2 = Input.mousePosition.y;

                if (y2 > y1 && !PauseMenu.IsPause)
                {
                    Destroy(Lzone);
                    bothclosed.SetActive(false);
                    Rclosed.SetActive(true);
                    Lawake = true;
                    //SceneManager.LoadScene("Day1_P2");
                }
            }
        }

        if (MitaRightRightSpace.OverRightEye)
        {
            if (Input.GetMouseButtonDown(0))
            {
                y1 = Input.mousePosition.y;
            }

            if (Input.GetMouseButtonUp(0))
            {
                y2 = Input.mousePosition.y;

                if (y2 > y1 && !PauseMenu.IsPause)
                {
                    Destroy(Rzone);
                    bothclosed.SetActive(false);
                    Lclosed.SetActive(true);
                    Rawake = true;
                    //SceneManager.LoadScene("Day1_P2");
                    IsWin = true;
                }
            }
        }

        if(Lawake && Rawake)
        {
            Lclosed.SetActive(false);
            Rclosed.SetActive(false);
            awaken.SetActive(true);
           // SceneManager.LoadScene("MainMenu");
        }
    }
}
