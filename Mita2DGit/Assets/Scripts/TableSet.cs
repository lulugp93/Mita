using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TableSet : MonoBehaviour
{
    
    public GameObject TableInPlace;
    public GameObject TableOutPlace;
    public GameObject CupButton;
    public GameObject CupInPlace;
    public GameObject CupOutPlace;
    public GameObject TableIsSet;

    public void TablSet()
    {
       
            TableInPlace.SetActive(true);
            TableOutPlace.SetActive(false);
            CupButton.SetActive(true);
           
        
    }

    public void CupSet()
    {
        CupButton.SetActive(false);
        CupOutPlace.SetActive(false);
        CupInPlace.SetActive(true);
        TableIsSet.SetActive(true);
        TableInPlace.SetActive(false);

    }
    public void Finished()
    {
        SceneManager.LoadScene("SpeechGame");
    }
}
