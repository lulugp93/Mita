using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitaPOVFloor : MonoBehaviour
{
    private float FloorTimer = 4f;
    private bool HandAvailable;
    public static bool IsWin;
    // Start is called before the first frame update
    void Start()
    {
        HandAvailable = false;
    }

    public void HelpUp()
    {
        if(HandAvailable == true)
        {
            IsWin = true;
            Debug.Log("U helped her up!");
        }
    }
    // Update is called once per frame
    void Update()
    {

        FloorTimer -= Time.deltaTime;
        // timerSeconds.text = timer.ToString("f0");
        if (FloorTimer <= 0)
        {
            HandAvailable = true;
           // SceneManager.LoadScene("Day1_P1");

        }

    }
}
