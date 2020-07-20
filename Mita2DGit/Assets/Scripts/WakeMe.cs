using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WakeMe : MonoBehaviour
{
    private float timer = 0f;
    int Clicks = 0;
    public GameObject Bubble1;
    public GameObject Bubble2;
    public GameObject Pose1;
    public GameObject Pose2;
    public GameObject Pose3;
    public AudioSource myFx;
    public AudioClip Rustle;
    public static bool IsWin = false;

    public void Sleepyhead()
    {

        //void OnMouseDown()
       // {
             Clicks++;
        // }
        myFx.PlayOneShot(Rustle);

        Debug.Log(Clicks);
        if (Clicks == 1 || Clicks == 4)
        {
            Bubble1.SetActive(true);
            Pose1.SetActive(false);
            //Pose3.SetActive(false);
            Pose2.SetActive(true);
            timer = 1f;
        }

        if (Clicks == 2 || Clicks == 5)
        {
            Bubble1.SetActive(false);
            Bubble2.SetActive(true);
            Pose2.SetActive(false);
            Pose3.SetActive(true);
            Bubble1.SetActive(false);
            timer = 1f;
            if (DayCounter.DayPoints == 11)
            {
                IsWin = true;
            }

        }

        if (Clicks == 3 || Clicks == 6)
        {
            Bubble2.SetActive(false);
            Pose3.SetActive(false);
            Pose2.SetActive(true);
            if (DayCounter.DayPoints == 1)
            {
                IsWin = true;
            }
            //SceneManager.LoadScene("Day1_P3");

        }
    }

    public void Start()
    {

    }

  

    public void Update()
    {
        timer -= Time.deltaTime;
        
        if (timer <= 0)
        {
            Bubble1.SetActive(false);
            Bubble2.SetActive(false);
        }
    }
    
  
}
