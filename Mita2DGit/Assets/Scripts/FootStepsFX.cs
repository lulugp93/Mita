using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepsFX : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip Foots;
    private bool Play;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (HandHolder.pointerDown)
        {
            // myFx.PlayOneShot(Foots);
            Play = true;
        }

       /* if(Play == true)
        {
            Play = false;
            myFx.PlayOneShot(Foots);
        }
        */
        

        if (!HandHolder.pointerDown)
        {
            myFx.Pause();
        }


    }
}
