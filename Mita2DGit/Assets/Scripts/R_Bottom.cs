using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_Bottom : MonoBehaviour
{
    [SerializeField]
    private Transform sbubRIGHT;
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private float deltaX, deltaY;
    private bool IsMouseDown;
    public static bool locked;
    public AudioSource myFx;
    public AudioClip hoverfx;
    public AudioClip Clickfx;
    public AudioClip Snapfx;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        IsMouseDown = false;
    }

    private void OnMouseEnter()
    {
        if (!IsMouseDown && !locked && !PauseMenu.IsPause)
        {

            myFx.PlayOneShot(hoverfx);

        }
    }

    private void OnMouseDown()
    {
        if (!locked && !PauseMenu.IsPause)
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
            myFx.PlayOneShot(Clickfx);
            IsMouseDown = true;
        }
    }

    private void OnMouseDrag()
    {
        if (!locked && !PauseMenu.IsPause)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
         
        }
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - sbubRIGHT.position.x) <=0.5f &&
            Mathf.Abs(transform.position.y - sbubRIGHT.position.y) <= 0.5f)
        {
            transform.position = new Vector2(sbubRIGHT.position.x, sbubRIGHT.position.y);
            locked = true;
            SppechWin.SpeechPoints += 1;
            myFx.PlayOneShot(Snapfx);
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
        IsMouseDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
