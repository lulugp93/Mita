using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pill1Drag : MonoBehaviour,  IPointerClickHandler,  IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler {

    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector2 initialPosition;
    private bool IsMouseDown;
    public AudioSource myFx;
    public AudioClip hoverfx;
    public AudioClip Clickfx;
    //public AudioClip Snapfx;

    void Start()
    {
        initialPosition = transform.position;
        IsMouseDown = false;
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
        if (!PauseMenu.IsPause)
        {
            myFx.PlayOneShot(Clickfx);
            IsMouseDown = true;
        }
         
    }

    private void OnMouseUp()
    {
        IsMouseDown = false;
    }


    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {

    }  

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("begin drag");
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("draggind");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("enddrag");
        canvasGroup.blocksRaycasts = true;
    }

 public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("Click Click");
    }

    void Update()
    {
        if (MazeColliderReset.Pill1IsTouched)
        {
            Debug.Log("Pill 1 You Touched it!");
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
            MazeColliderReset.Pill1IsTouched = false;
        }
    }
   
}
