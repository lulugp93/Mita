using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCupButton : MonoBehaviour

  
{
    private float timer = 0f;
    public GameObject FakeCup;
    public GameObject RealCup;
    public GameObject Feedback;


   public void WRONG()
    {
        Feedback.SetActive(true);
        timer = 3f;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        // timerSeconds.text = timer.ToString("f0");
        if (timer <= 0)
        {
            Feedback.SetActive(false);
        }
    }
}
