using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Flashbacks : MonoBehaviour
{
    public float FBtimer = 0f;
    public GameObject Glow;
    public GameObject Flashback;
    public GameObject Buttoz;
    public GameObject Uselace;

    public void OnMouseEnter()
    {
        if (gameObject.tag == "FBNeckLace" && DayCounter.Necklace == false)
        {
            Glow.SetActive(true);
        }
        if (gameObject.tag == "FBMinnie" && DayCounter.Minnie == false)
        {
            Glow.SetActive(true);
        }
        if (gameObject.tag == "FBPaint" && DayCounter.Paint == false)
        {
            Glow.SetActive(true);
        }
        if (gameObject.tag == "FBDip" && DayCounter.Diploma == false)
        {
            Glow.SetActive(true);
        }
        if (gameObject.tag == "FBWheelChair" && DayCounter.Wheelchair == false)
        {
            Glow.SetActive(true);
        }

    }
    public void OnMouseExit()
    {
        Glow.SetActive(false);
    }

    public void NecklaceFlashe()
    {
        if (DayCounter.Necklace == false)
        {
            Flashback.SetActive(true);
            DayCounter.Necklace = true;
            //Buttoz.SetActive(false);
            //Uselace.SetActive(true);
            FBtimer = 2f;
        }
    }

    public void MinnieFlash()
    {
        if (DayCounter.Minnie == false)
        {
            Flashback.SetActive(true);
            DayCounter.Minnie = true;
            //Buttoz.SetActive(false);
            //Uselace.SetActive(true);
            FBtimer = 2f;
        }
    }

    public void PaintFlash()
    {
        if (DayCounter.Paint == false)
        {
            Flashback.SetActive(true);
            DayCounter.Paint = true;
            //Buttoz.SetActive(false);
            //Uselace.SetActive(true);
            FBtimer = 2f;
        }
    }

    public void DiplomaFlash()
    {
        if (DayCounter.Diploma == false)
        {
            Flashback.SetActive(true);
            DayCounter.Diploma = true;
            //Buttoz.SetActive(false);
            //Uselace.SetActive(true);
            FBtimer = 2f;
        }
    }

    public void WheelFlash()
    {
        if (DayCounter.Wheelchair == false)
        {
            Flashback.SetActive(true);
            DayCounter.Wheelchair = true;
            //Buttoz.SetActive(false);
            //Uselace.SetActive(true);
            FBtimer = 2f;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        FBtimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        FBtimer -= Time.deltaTime;

        if (FBtimer <= 0)
        {
            Flashback.SetActive(false);
            

        }
    }
}

