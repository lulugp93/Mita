using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject OpenedMenu;
    public GameObject PauseButton;
    public static bool IsPause = false;
    // Start is called before the first frame update
    void Start()
    {
        //OpenedMenu.SetActive(false);
    }

    public void Open()
    {
        if (!IsPause)
        {
            OpenedMenu.SetActive(true);
            PauseButton.SetActive(false);
            IsPause = true;
            Time.timeScale = 0f;
        }
    }

    public void resume()
    {
        OpenedMenu.SetActive(false);
        PauseButton.SetActive(true);
        IsPause = false;
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        DayCounter.DayPoints = 0;
        IsPause = false;
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
