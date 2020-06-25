using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitaLeftEyeWake : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool OverLeftEye;
  
    void Start()
    {
        OverLeftEye = false;
    }
    public void OnMouseOver()
    {
        OverLeftEye = true;
        Debug.Log("That mi left eye!");
    }

    public void OnMouseExit()
    {
        OverLeftEye = false;
        Debug.Log("ok ye are gone");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
