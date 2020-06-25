using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pill2Drag : MonoBehaviour,  IPointerClickHandler,  IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler {

    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private bool IsMouseDown;
    public AudioSource myFx;
    public AudioClip hoverfx;
    public AudioClip Clickfx;

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
   
}
