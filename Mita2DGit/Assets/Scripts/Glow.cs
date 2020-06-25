using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    public GameObject Aura;
    void Start()
    {
        Aura.SetActive(false);
    }

    public void OnMouseOver()
    {
        if (!PauseMenu.IsPause)
        {
            Aura.SetActive(true);
        }
    }

    public void OnMouseExit()
    {
        Aura.SetActive(false);
    }
    void Update()
    {
        
    }
}
