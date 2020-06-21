using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCupButton : MonoBehaviour

  
{
    private float timer = 0f;
    public GameObject FakeCup;
    public GameObject RealCup;
    public GameObject Feedback;
    public GameObject Aura;

    void Start()
    {
        Aura.SetActive(false);
    }

    public void OnMouseOver()
    {
        Aura.SetActive(true);
    }

    public void OnMouseExit()
    {
        Aura.SetActive(false);
    }

    public void WRONG()
    {
        Feedback.SetActive(true);
        timer = 2f;
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
