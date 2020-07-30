using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DreamSwitch : MonoBehaviour
{
    private float Dreamtimer = 4f;
    // private Text timerSeconds;
    // Start is called before the first frame update
    void Start()
    {
        //timerSeconds = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Dreamtimer -= Time.deltaTime;
        // timerSeconds.text = timer.ToString("f0");
        if (Dreamtimer <= 0)
        {
            SceneManager.LoadScene("Day1_P1");
        }
    }
}
