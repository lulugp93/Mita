﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pill1Drag : MonoBehaviour, IPointerDownHandler {

 public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Click Click");
    }
   
}
