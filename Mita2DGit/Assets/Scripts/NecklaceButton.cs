using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecklaceButton : MonoBehaviour
{
    public float FBtimer = 0f;
    public GameObject FlashbackImage;
    public GameObject Buttoz;
    public GameObject Uselace;


    public void NecklaceFlash()
    {
        FlashbackImage.SetActive(true);
        //Buttoz.SetActive(false);
        //Uselace.SetActive(true);
        FBtimer = 2f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FBtimer -= Time.deltaTime;

        if (FBtimer <= 0)
        {
            FlashbackImage.SetActive(false);
            

        }
    }
}

