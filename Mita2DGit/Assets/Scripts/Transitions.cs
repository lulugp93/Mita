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

        if (DayCounter.DayPoints == 1 || DayCounter.DayPoints == 11)
        {
            if (WakeMe.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 2 || DayCounter.DayPoints == 7 || DayCounter.DayPoints == 12 || DayCounter.DayPoints == 16)
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
                TableSetter.locked = false;
                CupSetter.locked = false;
            }
        }

        if (DayCounter.DayPoints == 4 || DayCounter.DayPoints == 14)
        {
            if (SppechWin.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
                SppechWin.SpeechPoints = 0;
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

        if (DayCounter.DayPoints == 6 || DayCounter.DayPoints == 15)
        {
            if (MitaPOVwake.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 8 || DayCounter.DayPoints == 17)
        {
            if (HandWasher.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 9 || DayCounter.DayPoints == 18)
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
            if (DayCounter.DayPoints == 14)
            {
                AlarmSwipe.IsWin = false;
                WakeMe.IsWin = false;
                HandHolder.IsWin = false;
                CupSetter.IsWin = false;
                SppechWin.IsWin = false;
                Stereo.IsWin = false;
                MitaPOVwake.IsWin = false;
                HandWasher.IsWin = false;
                NewMazeGoal.IsWin = false;
                TransitionAnim.SetTrigger("end");
                yield return new WaitForSeconds(1.5f);
                SceneManager.LoadScene("MitaWakePOV");
            }
            else
            {
                AlarmSwipe.IsWin = false;
                WakeMe.IsWin = false;
                HandHolder.IsWin = false;
                CupSetter.IsWin = false;
                SppechWin.IsWin = false;
                Stereo.IsWin = false;
                MitaPOVwake.IsWin = false;
                HandWasher.IsWin = false;
                NewMazeGoal.IsWin = false;
                TransitionAnim.SetTrigger("end");
                yield return new WaitForSeconds(1.5f);
                SceneManager.LoadScene(SceneName);
            }

        }
    }
}
