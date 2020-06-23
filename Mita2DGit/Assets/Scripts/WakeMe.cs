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

    public void Sleepyhead()
    {

        //void OnMouseDown()
       // {
             Clicks++; 
       // }

        Debug.Log(Clicks);
        if (Clicks == 1)
        {
            Bubble1.SetActive(true);
            Pose1.SetActive(false);
            Pose2.SetActive(true);
            timer = 1f;
        }

        if (Clicks == 2)
        {
            Bubble1.SetActive(false);
            Bubble2.SetActive(true);
            Pose2.SetActive(false);
            Pose3.SetActive(true);
            Bubble1.SetActive(false);
            timer = 1f;

        }

        if (Clicks == 3)
        {
            Bubble2.SetActive(false);
            Pose3.SetActive(false);
            SceneManager.LoadScene("Day1_P3");
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
