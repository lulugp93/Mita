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

        if (DayCounter.DayPoints == 0 || DayCounter.DayPoints == 10 || DayCounter.DayPoints == 19 || DayCounter.DayPoints == 30 || DayCounter.DayPoints == 39 || DayCounter.DayPoints == 48 
            || DayCounter.DayPoints == 58 || DayCounter.DayPoints == 67 || DayCounter.DayPoints == 78 || DayCounter.DayPoints == 87 || DayCounter.DayPoints == 97)
        {
            if (AlarmSwipe.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 1 || DayCounter.DayPoints == 11 || DayCounter.DayPoints == 20 || DayCounter.DayPoints == 31 || DayCounter.DayPoints == 40 || DayCounter.DayPoints == 49
            || DayCounter.DayPoints == 59 || DayCounter.DayPoints == 68 || DayCounter.DayPoints == 79 || DayCounter.DayPoints == 88)
        {
            if (WakeMe.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 2 || DayCounter.DayPoints == 7 || DayCounter.DayPoints == 12 || DayCounter.DayPoints == 16 || DayCounter.DayPoints == 21 || DayCounter.DayPoints == 27
            || DayCounter.DayPoints == 32 || DayCounter.DayPoints == 36 || DayCounter.DayPoints == 41 || DayCounter.DayPoints == 45 || DayCounter.DayPoints == 50 || DayCounter.DayPoints == 55
            || DayCounter.DayPoints == 60 || DayCounter.DayPoints == 64 || DayCounter.DayPoints == 69 || DayCounter.DayPoints == 75 || DayCounter.DayPoints == 80 || DayCounter.DayPoints == 84
            || DayCounter.DayPoints == 89 || DayCounter.DayPoints == 94)
        {
            if (HandHolder.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 3 || DayCounter.DayPoints == 13 || DayCounter.DayPoints == 22 || DayCounter.DayPoints == 33 || DayCounter.DayPoints == 42 || DayCounter.DayPoints == 51
            || DayCounter.DayPoints == 61 || DayCounter.DayPoints == 70 || DayCounter.DayPoints == 81 || DayCounter.DayPoints == 90)
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

        if (DayCounter.DayPoints == 4 || DayCounter.DayPoints == 14 || DayCounter.DayPoints == 23 || DayCounter.DayPoints == 34 || DayCounter.DayPoints == 43 || DayCounter.DayPoints == 52
            || DayCounter.DayPoints == 62 || DayCounter.DayPoints == 71 || DayCounter.DayPoints == 82 || DayCounter.DayPoints == 91)
        {
            if (SppechWin.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
                SppechWin.SpeechPoints = 0;
            }
        }

        if (DayCounter.DayPoints == 5 || DayCounter.DayPoints == 24 || DayCounter.DayPoints == 53 || DayCounter.DayPoints == 72 || DayCounter.DayPoints == 92)
        {
            if (Stereo.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 6 || DayCounter.DayPoints == 15 || DayCounter.DayPoints == 25 || DayCounter.DayPoints == 35 || DayCounter.DayPoints == 44 || DayCounter.DayPoints == 54 
            || DayCounter.DayPoints == 63 || DayCounter.DayPoints == 73 || DayCounter.DayPoints == 83 || DayCounter.DayPoints == 93)
        {
            if (MitaPOVwake.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 8 || DayCounter.DayPoints == 17 || DayCounter.DayPoints == 28 || DayCounter.DayPoints == 37 || DayCounter.DayPoints == 46 || DayCounter.DayPoints == 56 
            || DayCounter.DayPoints == 65 || DayCounter.DayPoints == 76 || DayCounter.DayPoints == 85 || DayCounter.DayPoints == 95)
        {
            if (HandWasher.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 9 || DayCounter.DayPoints == 18 || DayCounter.DayPoints == 29 || DayCounter.DayPoints == 38 || DayCounter.DayPoints == 47 || DayCounter.DayPoints == 57
            || DayCounter.DayPoints == 66 || DayCounter.DayPoints == 77 || DayCounter.DayPoints == 86 || DayCounter.DayPoints == 96)
        {
            if (NewMazeGoal.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        if (DayCounter.DayPoints == 26 || DayCounter.DayPoints == 74)
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
            if (DayCounter.DayPoints == 14 || DayCounter.DayPoints == 34 || DayCounter.DayPoints == 43 || DayCounter.DayPoints == 62 || DayCounter.DayPoints == 82)
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
            else if (DayCounter.DayPoints == 25 || DayCounter.DayPoints == 73)
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
            else if (DayCounter.DayPoints == 96)
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
                SceneManager.LoadScene("GoldenDream");
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
