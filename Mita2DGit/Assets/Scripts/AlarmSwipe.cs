using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AlarmSwipe : MonoBehaviour
{

    private bool CT1;
    public GameObject Phone;
    public GameObject PhoneAura;
    public GameObject Phone2;
    public GameObject Phone2Aura;
    public GameObject Phone2Button;
    public static bool IsWin = false;
    public float x1;
    public float x2;

    // Start is called before the first frame update
    void Start()
    {
        if(DayCounter.DayPoints == 0 || DayCounter.DayPoints == 19 || DayCounter.DayPoints == 30)
        {
            Phone.SetActive(true);
            PhoneAura.SetActive(true);
            CT1 = true;
        }

        if (DayCounter.DayPoints == 10)
        {
            Phone2.SetActive(true);
            Phone2Aura.SetActive(true);
            Phone2Button.SetActive(true);
            CT1 = false;
        }
    }

    public void BlockBerryAlarmOff()
    {
        IsWin = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            x1 = Input.mousePosition.x;
        }

        if (Input.GetMouseButtonUp(0))
        {
            x2 = Input.mousePosition.x;

            if (x2 > x1 && !PauseMenu.IsPause && CT1 == true)
            {
                //Destroy(Phone);
                //SceneManager.LoadScene("Day1_P2");
                IsWin = true;
            }
        }
    }
}
