﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CupSetter : MonoBehaviour
{
    [SerializeField]
    //private float  cuptimer;
    private Transform sbubMID;
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private float deltaX, deltaY;
    public static bool locked;
 
    public GameObject CupOOP;
    public GameObject CupIP;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    private void OnMouseDown()
    {
        if (!locked)
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }
    }

    private void OnMouseDrag()
    {
        if (!locked)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
        }
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - sbubMID.position.x) <=0.5f &&
            Mathf.Abs(transform.position.y - sbubMID.position.y) <= 0.5f)
        {
            transform.position = new Vector2(sbubMID.position.x, sbubMID.position.y);
            locked = true;
            CupIP.SetActive(true);
           CupOOP.SetActive(false);
            SceneManager.LoadScene("SpeechGame");
            //cuptimer = 2f;


        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
       // cuptimer -= Time.deltaTime;
        // timerSeconds.text = timer.ToString("f0");
        //if (cuptimer <= 0)
        //{
           // SceneManager.LoadScene("Day1_P1");
        //}
    }
}