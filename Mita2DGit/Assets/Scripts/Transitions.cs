using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transitions : MonoBehaviour
{
    public string SceneName;
    public Animator TransitionAnim;
    public string WinScript;
    // public object Checker;
    public static bool Complete;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            DayCounter.DayPoints += 1;
        }

        if (DayCounter.DayPoints == 0 || DayCounter.DayPoints == 10)
        {
            if (AlarmSwipe.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 1)
        {
            if (WakeMe.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 2 || DayCounter.DayPoints == 7)
        {
            if (HandHolder.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 3 || DayCounter.DayPoints == 13)
        {
            if (CupSetter.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 4)
        {
            if (SppechWin.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 5)
        {
            if (Stereo.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 6)
        {
            if (MitaPOVwake.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 8)
        {
            if (HandWasher.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 9)
        {
            if (NewMazeGoal.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }





        IEnumerator LoadScene()
        {
            AlarmSwipe.IsWin = false;
            WakeMe.IsWin = false;
            HandHolder.IsWin = false;
            TableSet.IsWin = false;
            SppechWin.IsWin = false;
            Stereo.IsWin = false;
            MitaPOVwake.IsWin = false;
            HandWasher.IsWin = false;
            TransitionAnim.SetTrigger("end");
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(SceneName);
        }
    }
}
