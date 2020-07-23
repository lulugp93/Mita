using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public GameObject Credits;
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("Prompt");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void CreditScreen()
    {
        SceneManager.LoadScene("Credits");
    }
    
    public void CloseCredits()
    {
        Credits.SetActive(false);
    }


}
