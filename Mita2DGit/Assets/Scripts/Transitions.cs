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
        if (DayCounter.DayPoints == 0)
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

        if (DayCounter.DayPoints == 2)
        {
            if (HandHolder.IsWin)
            {
                StartCoroutine(LoadScene());
                Complete = true;
                DayCounter.DayPoints += 1;
            }
        }

        IEnumerator LoadScene()
        {
            AlarmSwipe.IsWin = false;
            TransitionAnim.SetTrigger("end");
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(SceneName);
        }
    }
}
