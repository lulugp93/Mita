using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WakeMe : MonoBehaviour
{
    int Clicks = 0;
    public GameObject Bubble1;
    public GameObject Bubble2;

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
        }

        if (Clicks == 2)
        {
            Bubble1.SetActive(false);
            Bubble2.SetActive(true);
        }

        if (Clicks == 3)
        {
            Bubble2.SetActive(false);
            SceneManager.LoadScene("Day1_P4");
        }
    }

    public void Start()
    {

    }

  

    public void Update()
    {
       
    }
    
  
}
