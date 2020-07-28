using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HandWasher : MonoBehaviour
{
    public bool InZone;
    //private bool Entered;
    public GameObject MirrorBooBoo;
    public GameObject MirrorHallu1;
    public GameObject LittleGirlHallu;
    private float WashTimer;
    public float RequiredTime;
    public Image BubbleBar;
    public AudioSource myFx;
    public AudioClip Faucet;
    public Texture2D RegCursor;
    public Texture2D WashingCursor;
    [SerializeField] ParticleSystem SoapBubbles = null;
    public static bool IsWin = false;
    //float MaxBubble = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InZone = false;  
        if (DayCounter.DayPoints == 28 || DayCounter.DayPoints == 76)
        {
            MirrorBooBoo.SetActive(true);
        }
        if (DayCounter.DayPoints == 37 || DayCounter.DayPoints == 76 || DayCounter.DayPoints == 95)
        {
            MirrorHallu1.SetActive(true);
        }
        if(DayCounter.DayPoints == 46 || DayCounter.DayPoints == 56)
        {
            LittleGirlHallu.SetActive(true);
        }
    }

    public void OnMouseEnter()
    {
        Cursor.SetCursor(WashingCursor, new Vector2(10, 10), CursorMode.ForceSoftware);
        InZone = true;
        SoapBubbles.Play();
        // Entered = true;
        myFx.PlayOneShot(Faucet);
        Debug.Log("Ur in da zone!");
    }

    public void OnMouseExit()
    {
        Cursor.SetCursor(RegCursor, new Vector2(10, 10), CursorMode.ForceSoftware);
        InZone = false;
        SoapBubbles.Stop();
        myFx.Pause();
        Debug.Log("Ur Out of da zone!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(WashTimer);
        if (InZone)
        {
           
            WashTimer += Time.deltaTime;
            if (WashTimer >= RequiredTime)
            {
                Cursor.SetCursor(RegCursor, new Vector2(10, 10), CursorMode.ForceSoftware);
                // SceneManager.LoadScene("MainMenu");
                IsWin = true;
                // Debug.Log("You Wshed ur hands!");

            }
        }
        if (!InZone)
        {

           
            WashTimer -= Time.deltaTime;
            if (WashTimer <= 0)
            {
                WashTimer = 0;

            }
        }
        BubbleBar.fillAmount = WashTimer / RequiredTime;
    }
}
