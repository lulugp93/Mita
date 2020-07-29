using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] ParticleSystem StartPart = null;
    [SerializeField] ParticleSystem CredPart = null;
    [SerializeField] ParticleSystem QuitPart = null;

    public void StartParticles()
    {
        StartPart.Play();
    }

    public void CreditParticles()
    {
        CredPart.Play();
    }
    public void QuitParticles()
    {
        QuitPart.Play();
    }

    public void OnMouseExit()
    {
        StartPart.Stop();
        CredPart.Stop();
        QuitPart.Stop();
    }

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
