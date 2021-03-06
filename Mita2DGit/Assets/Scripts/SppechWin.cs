﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SppechWin : MonoBehaviour
{
    public static bool IsWin = false;
    public GameObject piece1;
    public GameObject piece2;
    public GameObject piece3;
    public GameObject piece4;
    public GameObject piece5;
    public GameObject piece6;
    public GameObject CT1piece1;
    public GameObject CT1piece2;
    public GameObject CT1piece3;
    public GameObject CT1piece4;
    public GameObject CT1piece5;
    public GameObject CT1piece6;
    public GameObject CT1Figure;
    public GameObject CT2Figure;
    public static int SpeechPoints;
    private int NeededPoints;

    // Start is called before the first frame update
    void Start()
    {
        L_Bubble.locked = false;
        M_Bubble.locked = false;
        R_Bubble.locked = false;
        L_Bottom.locked = false;
        M_Bottom.locked = false;
        R_Bottom.locked = false;
        SpeechPoints = 0;

        if(DayCounter.DayPoints == 4 || DayCounter.DayPoints == 52 || DayCounter.DayPoints == 91)
        {
            NeededPoints = 5;
            CT1piece1.SetActive(true);
            CT1piece3.SetActive(true);
            CT1piece4.SetActive(true);
            CT1piece5.SetActive(true);
            CT1piece6.SetActive(true);
            CT1Figure.SetActive(true);

        }

        if (DayCounter.DayPoints == 23)
        {
            NeededPoints = 4;
            CT1piece2.SetActive(true);
            CT1piece4.SetActive(true);
            CT1piece5.SetActive(true);
            CT1piece6.SetActive(true);

            CT1Figure.SetActive(true);

        }
        if (DayCounter.DayPoints == 71)
        {
            NeededPoints = 3;
            CT1piece2.SetActive(true);
            CT1piece4.SetActive(true);
            CT1piece6.SetActive(true);
            CT1Figure.SetActive(true);

        }

        if (DayCounter.DayPoints == 14 || DayCounter.DayPoints == 43 || DayCounter.DayPoints == 62 || DayCounter.DayPoints == 82)
        {
            NeededPoints = 6;
            piece1.SetActive(true);
            piece2.SetActive(true);
            piece3.SetActive(true);
            piece4.SetActive(true);
            piece5.SetActive(true);
            piece6.SetActive(true);
            CT2Figure.SetActive(true);
           // piece3.SetActive(false);

        }

        if (DayCounter.DayPoints == 34)
        {
            NeededPoints = 6;
            CT1piece1.SetActive(true);
            CT1piece2.SetActive(true);
            CT1piece3.SetActive(true);
            CT1piece4.SetActive(true);
            CT1piece5.SetActive(true);
            CT1piece6.SetActive(true);
            CT1Figure.SetActive(true);
            CT1Figure.SetActive(true);
            // piece3.SetActive(false);

        }

    }

    // Update is called once per frame
    void Update()
    {
       

        if (SpeechPoints == NeededPoints)
        {
            IsWin = true;
            
        }
        /*
         * if (L_Bubble.locked && M_Bubble.locked && R_Bubble.locked && L_Bottom.locked && M_Bottom.locked && R_Bottom.locked)
        {
            SceneManager.LoadScene("PillMaze");
        }
        */
    }
}
