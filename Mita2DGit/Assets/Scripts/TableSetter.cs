using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TableSetter : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler
{
    [SerializeField]
   
    private Transform sbubMID;
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private float deltaX, deltaY;
    public static bool locked;
    private bool IsMouseDown;
    public GameObject TableinPlace;
    public GameObject TableOut;
    public GameObject FakeCup;
    public GameObject realCup;
    public GameObject TableShadow;
    public GameObject Flashback;
    public AudioSource myFx;
    public AudioClip hoverfx;
    public AudioClip Clickfx;
    public AudioClip Snapfx;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        IsMouseDown = false;
        //locked = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!PauseMenu.IsPause)
        {
            myFx.PlayOneShot(hoverfx);
        }
    }
    private void OnMouseEnter()
    {
        if (!IsMouseDown && !PauseMenu.IsPause)
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
            TableShadow.SetActive(true);
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
        TableShadow.SetActive(false);
        if (Mathf.Abs(transform.position.x - sbubMID.position.x) <=0.5f &&
            Mathf.Abs(transform.position.y - sbubMID.position.y) <= 0.5f)
        {
            transform.position = new Vector2(sbubMID.position.x, sbubMID.position.y);
            locked = true;
            TableinPlace.SetActive(true);
           TableOut.SetActive(false);
            FakeCup.SetActive(false);
            realCup.SetActive(true);
            Flashback.SetActive(false);
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
