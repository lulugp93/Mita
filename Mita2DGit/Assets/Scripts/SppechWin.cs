using System.Collections;
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
    public static int SpeechPoints;
    private int NeededPoints;

    // Start is called before the first frame update
    void Start()
    {

        SpeechPoints = 0;

        if(DayCounter.DayPoints == 4)
        {
            NeededPoints = 5;
            piece3.SetActive(false);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
       /* if (L_Bubble.locked)
        {
            SpeechPoints += 1;
        }

        if (M_Bubble.locked)
        {
            SpeechPoints += 1;
        }

        if (R_Bubble.locked)
        {
            SpeechPoints += 1;
        }
        if (L_Bottom.locked)
        {
            SpeechPoints += 1;
        }

        if (M_Bottom.locked)
        {
            SpeechPoints += 1;
        }

        if (R_Bottom.locked)
        {
            SpeechPoints += 1;
        }
        */

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
