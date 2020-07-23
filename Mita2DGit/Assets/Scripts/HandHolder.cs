using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class HandHolder : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool pointerDown;
    private float pointerDownTimer;
    public float requiredHoldTime;
    public GameObject HandisHeld;
    public GameObject HandnotHeld;
    public GameObject CT2Hold;
    public GameObject CT2NotHold;
    public GameObject LittleHallucnation1;
    private bool Played;
    public AudioSource myFx;
    public AudioClip Foots;
    public static bool IsWin = false;
    public GameObject HandButton;
    public GameObject BooBoo;
    public GameObject NotHoldBooBoo;
    public GameObject FaceScribbleStill;
    public GameObject FaceScribbleWalk;

    [SerializeField] private Animator myAnimationController;
   

    //public UnityEvent onLongClick;
    public void FootstepsFX()
    {
        if (Played == false)
        {
            myFx.PlayOneShot(Foots);
            Played = true;
        }
        if(Played == true)
        {
            myFx.UnPause();
        }
    }

    public void PauseFeets()
    {
        myFx.Pause();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!PauseMenu.IsPause)
        {
            
            if (DayCounter.DayPoints == 12 || DayCounter.DayPoints == 41)
            {
                myAnimationController.enabled = true;
                myAnimationController.SetBool("MoveRoom", true);
                pointerDown = true;
                CT2Hold.SetActive(true);
                CT2NotHold.SetActive(false);
               // Debug.Log("OnPointerDown");
            }

            else
            {
                myAnimationController.enabled = true;
                myAnimationController.SetBool("MoveRoom", true);
                pointerDown = true;
                HandisHeld.SetActive(true);
                HandnotHeld.SetActive(false);
               // Debug.Log("OnPointerDown");
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
        Reset();
        //Debug.Log("OnPointerUp");
        
    }
    // Start is called before the first frame update
    void Start()
    {
        pointerDown = false;
        pointerDownTimer = 0f;
        requiredHoldTime = 3.7f;
        myAnimationController.enabled = false;
        if(DayCounter.DayPoints == 2 || DayCounter.DayPoints == 21 || DayCounter.DayPoints == 32)
        {
            HandnotHeld.SetActive(true);
        }
        if (DayCounter.DayPoints == 12 || DayCounter.DayPoints == 41)
        {
            CT2NotHold.SetActive(true);
        }
        if (DayCounter.DayPoints == 16)
        {
            LittleHallucnation1.SetActive(true);
        }
        if (DayCounter.DayPoints == 21)
        {
            BooBoo.SetActive(true);
            NotHoldBooBoo.SetActive(true);
        }

        if (DayCounter.DayPoints == 36 || DayCounter.DayPoints == 45)
        {
            FaceScribbleStill.SetActive(true);
            FaceScribbleWalk.SetActive(true);
        }

        /*
         * if (DayCounter.DayPoints != 21)
        {
            BooBoo.SetActive(false);
            NotHoldBooBoo.SetActive(false);
        }
        */
    }

    // Update is called once per frame
    private void Update()
    {
        if (pointerDown)
        {
            
            pointerDownTimer += Time.deltaTime;
            if(pointerDownTimer >= requiredHoldTime)
            {
                
                myAnimationController.enabled = false;
                HandButton.SetActive(false);
                IsWin = true;
               // SceneManager.LoadScene("Day1_P4");
                // Debug.Log("Change Scene Nao PLS");

            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log(pointerDownTimer);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(requiredHoldTime);
        }
    }

    private void Reset()
    {
        if (DayCounter.DayPoints == 12 || DayCounter.DayPoints == 41)
        {
            pointerDown = false;
            // myAnimationController.SetBool("MoveRoom", false);
            myAnimationController.enabled = false;
            CT2Hold.SetActive(false);
            CT2NotHold.SetActive(true);
        }

        else
        {
            pointerDown = false;
            // myAnimationController.SetBool("MoveRoom", false);
            myAnimationController.enabled = false;
            HandisHeld.SetActive(false);
            HandnotHeld.SetActive(true);
        }
        
    }
}
