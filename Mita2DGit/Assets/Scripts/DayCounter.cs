﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCounter : MonoBehaviour
{
    public static int DayPoints;
    public static bool Necklace;
    public static bool Minnie;
    public static bool Paint;
    public static bool Diploma;
    public static bool Wheelchair;
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.J))
        {
            DayPoints += 1;
        }
       
        if (Transitions.Complete)
        {
            DayPoints += 1;
        }
         */

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(DayPoints);
        }
    }
}
