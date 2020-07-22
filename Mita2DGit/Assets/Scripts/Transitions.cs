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

        if (DayCounter.DayPoints == 0 || DayCounter.DayPoints == 10 || DayCounter.DayPoints == 19 || DayCounter.DayPoints == 30)
        {
            if (AlarmSwipe.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 1 || DayCounter.DayPoints == 11 || DayCounter.DayPoints == 20 || DayCounter.DayPoints == 31)
        {
            if (WakeMe.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 2 || DayCounter.DayPoints == 7 || DayCounter.DayPoints == 12 || DayCounter.DayPoints == 16 || DayCounter.DayPoints == 21 || DayCounter.DayPoints == 27
            || DayCounter.DayPoints == 32)
        {
            if (HandHolder.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 3 || DayCounter.DayPoints == 13 || DayCounter.DayPoints == 22 || DayCounter.DayPoints == 33)
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

        if (DayCounter.DayPoints == 4 || DayCounter.DayPoints == 14 || DayCounter.DayPoints == 23 || DayCounter.DayPoints == 34)
        {
            if (SppechWin.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
                SppechWin.SpeechPoints = 0;
            }
        }

        if (DayCounter.DayPoints == 5 || DayCounter.DayPoints == 24)
        {
            if (Stereo.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 6 || DayCounter.DayPoints == 15 || DayCounter.DayPoints == 25)
        {
            if (MitaPOVwake.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 8 || DayCounter.DayPoints == 17 || DayCounter.DayPoints == 28)
        {
            if (HandWasher.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 9 || DayCounter.DayPoints == 18 || DayCounter.DayPoints == 29)
        {
            if (NewMazeGoal.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 26)
        {
            if (MitaPOVFloor.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }





        IEnumerator LoadScene()
        {
            if (DayCounter.DayPoints == 14 || DayCounter.DayPoints == 34)
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
                MitaPOVFloor.IsWin = false;
                TransitionAnim.SetTrigger("end");
                yield return new WaitForSeconds(1.5f);
                SceneManager.LoadScene("MitaWakePOV");
            }
            else if (DayCounter.DayPoints == 25)
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
                MitaPOVFloor.IsWin = false;
                TransitionAnim.SetTrigger("end");
                yield return new WaitForSeconds(1.5f);
                SceneManager.LoadScene("MitaFloorPOV");
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
                MitaPOVFloor.IsWin = false;
                TransitionAnim.SetTrigger("end");
                yield return new WaitForSeconds(1.5f);
                SceneManager.LoadScene(SceneName);
            }

        }
    }
}
