using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class HandHolder : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool pointerDown;
    private float pointerDownTimer;
    public float requiredHoldTime;
    public GameObject HandisHeld;
    public GameObject HandnotHeld;
    public GameObject CT2Hold;
    public GameObject CT2NotHold;
    public static bool IsWin = false;
    public GameObject HandButton;

    [SerializeField] private Animator myAnimationController;
   

    //public UnityEvent onLongClick;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!PauseMenu.IsPause)
        {
            if (DayCounter.DayPoints == 12)
            {
                myAnimationController.enabled = true;
                myAnimationController.SetBool("MoveRoom", true);
                pointerDown = true;
                CT2Hold.SetActive(true);
                CT2NotHold.SetActive(false);
                Debug.Log("OnPointerDown");
            }

            else
            {
                myAnimationController.enabled = true;
                myAnimationController.SetBool("MoveRoom", true);
                pointerDown = true;
                HandisHeld.SetActive(true);
                HandnotHeld.SetActive(false);
                Debug.Log("OnPointerDown");
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Reset();
        Debug.Log("OnPointerUp");
        
    }
    // Start is called before the first frame update
    void Start()
    {
        myAnimationController.enabled = false;
        if(DayCounter.DayPoints == 2)
        {
            HandnotHeld.SetActive(true);
        }
        if (DayCounter.DayPoints == 12)
        {
            CT2NotHold.SetActive(true);
        }
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
    }

    private void Reset()
    {
        if (DayCounter.DayPoints == 12)
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
