using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeColliderReset : MonoBehaviour
{
    public static bool Pill1IsTouched;
    public static bool PillIsTouched;


    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "Pill")
        {
            PillIsTouched = true;
        }
        if (col.gameObject.tag == "Pill1")
        {
            Pill1IsTouched = true;
        }
        
    } // Start is called before the first frame update
    void Start()
    {
       PillIsTouched = false;
        Pill1IsTouched = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
