using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WakeMe : MonoBehaviour
{
    private float timer = 0f;
    int Clicks = 0;
    int NeededClicks = 0;
    public GameObject TapZone;
    public GameObject FloorButton;
    public GameObject Bubble1;
    public GameObject Bubble2;
    public GameObject Pose1;
    public GameObject Pose2;
    public GameObject Pose3;
    private float CreditsTimer;
    public float EndTime;
    public AudioSource myFx;
    public AudioClip Rustle;
    public static bool IsWin = false;
    public Animator myAnimationController;
    public GameObject MinnieButton;

    public void Sleepyhead()
    {

        //void OnMouseDown()
       // {
             Clicks++;
        // }
        myFx.PlayOneShot(Rustle);

        if (DayCounter.DayPoints != 98)
        {
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
                /*
                 * if (DayCounter.DayPoints == 11)
                {
                    IsWin = true;
                }
                */

            }

            if (Clicks == 3 || Clicks == 6)
            {
                Bubble2.SetActive(false);
                Bubble1.SetActive(true);
                Pose3.SetActive(false);
                Pose1.SetActive(true);
                timer = 1f;
                /* if (DayCounter.DayPoints == 1)
                 {
                     IsWin = true;
                 }
                 */
                //SceneManager.LoadScene("Day1_P3");

            }
        }
        
    }

    public void OnMouseDown()
    {
        if (DayCounter.DayPoints == 98)
        {
            myAnimationController.enabled = true;
            myAnimationController.SetBool("EndCredits", true);
            CreditsTimer += Time.deltaTime;

        }
        
    }

    public void OnMouseUp()
    {
        if (DayCounter.DayPoints == 98)
        {
            myAnimationController.enabled = false;
        }
       /* if (CreditsTimer <= 0)
        {
            SceneManager.LoadScene("Credits");
        }
        */
    }

    public void Start()
    {
        CreditsTimer = 0f;
        EndTime = 0.4f;
        Clicks = 0;

        if (DayCounter.DayPoints > 30 && DayCounter.Minnie == false)
        {
            MinnieButton.SetActive(true);
        }
      
        if (DayCounter.DayPoints == 98)
        {
            Pose2.SetActive(true);
            Pose1.SetActive(false);
        }
        myAnimationController.enabled = false;
        if (DayCounter.DayPoints == 79)
        {
            NeededClicks = 1;
        }
        if (DayCounter.DayPoints == 1 || DayCounter.DayPoints == 40 || DayCounter.DayPoints == 88)
        {
            NeededClicks = 3;
        }

        if (DayCounter.DayPoints == 11)
        {
            NeededClicks = 2;
        }
        if (DayCounter.DayPoints == 31 || DayCounter.DayPoints == 49)
        {
            NeededClicks = 4;
        }
        if (DayCounter.DayPoints == 59)
        {
            NeededClicks = 6;
        }
        if (DayCounter.DayPoints == 20 || DayCounter.DayPoints == 68)
        {
            IsWin = false;
            NeededClicks = 1000;
            Pose1.SetActive(false);
            TapZone.SetActive(false);
            FloorButton.SetActive(true);
            
        }
    }

    public void FloorWin()
    {
        
            IsWin = true;
        
    }

  

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(CreditsTimer);
        }
        if (CreditsTimer >= EndTime)
        {
            Debug.Log("You should transition now");
            DayCounter.DayPoints = 0;
            SceneManager.LoadScene("Credits");
        }

        timer -= Time.deltaTime;
        
        if (timer <= 0)
        {
            Bubble1.SetActive(false);
            Bubble2.SetActive(false);
        }
        if(Clicks == NeededClicks)
        {
            IsWin = true;
        }
    }
    
  
}
