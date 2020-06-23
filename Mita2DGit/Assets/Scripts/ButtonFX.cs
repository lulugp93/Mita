using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFX : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip hoverfx;
    public AudioClip Clickfx;

    public void HoverSound()
    {
        myFx.PlayOneShot(hoverfx);
    }

    public void ClickSound()
    {
        myFx.PlayOneShot(Clickfx);
    }
}
