using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    //public string levelToLoad;
    private float timer = 4f;
   // private Text timerSeconds;
    // Start is called before the first frame update
    void Start()
    {
        //timerSeconds = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
       // timerSeconds.text = timer.ToString("f0");
        if(timer <= 0){
            SceneManager.LoadScene("Day1_P1");
        }
    }
}
