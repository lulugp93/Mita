using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stereo : MonoBehaviour
{
    public GameObject Disc1;
    public GameObject Disc2;
    public GameObject Disc3;
    public GameObject NeutralFace;
    public GameObject UhOhFace;
    public GameObject HappyFace;
    public AudioSource myFx;
    public AudioClip Song1;
    public AudioClip Song2;
    public AudioClip Song3;
    private static bool Disc1In = false;
    private static bool Disc2In = false;
    private static bool Disc3In = false;

    public void LoadMusic()
    {
        if (!Disc1In && !Disc2In && !Disc3In)
        {
            if (gameObject.tag == "Case1")
            {
                Disc1.SetActive(true);
                Disc1In = true;
            }
            if (gameObject.tag == "Case2")
            {
                Disc2.SetActive(true);
                Disc2In = true;
            }
            if (gameObject.tag == "Case3")
            {
                Disc3.SetActive(true);
                Disc3In = true;
            }
        }
    } 

    public void StopMusic()
    {
        Disc1.SetActive(false);
        Disc2.SetActive(false);
        Disc3.SetActive(false);
        Disc1In = false;
        Disc2In = false;
        Disc3In = false;
        NeutralFace.SetActive(true);
        HappyFace.SetActive(false);
        UhOhFace.SetActive(false);
    }

    public void PlayMusic()
    {
        if (Disc1In)
        {
            myFx.PlayOneShot(Song1);
            Debug.Log("Song 1 is Playing");
            NeutralFace.SetActive(false);
            UhOhFace.SetActive(true);
        }
        if (Disc2In)
        {
            myFx.PlayOneShot(Song2);
            Debug.Log("Song 2 is Playing");
            NeutralFace.SetActive(false);
            HappyFace.SetActive(true);
        }
        if (Disc3In)
        {
            myFx.PlayOneShot(Song3);
            Debug.Log("Song 3 is Playing");
            NeutralFace.SetActive(false);
            UhOhFace.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
