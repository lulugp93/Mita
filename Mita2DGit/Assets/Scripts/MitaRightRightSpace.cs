using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitaRightRightSpace : MonoBehaviour
{
    public static bool OverRightEye;

    void Start()
    {
        OverRightEye = false;
    }
    public void OnMouseOver()
    {
        OverRightEye = true;
        Debug.Log("That mi right eye!");
    }

    public void OnMouseExit()
    {
        OverRightEye = false;
        Debug.Log("ok ye are gone");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
