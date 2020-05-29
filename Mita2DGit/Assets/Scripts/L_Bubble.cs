using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_Bubble : MonoBehaviour
{
    [SerializeField]
    private Transform sbubLEFT;
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private float deltaX, deltaY;
    public static bool locked;
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
        if (Mathf.Abs(transform.position.x - sbubLEFT.position.x) <=0.5f &&
            Mathf.Abs(transform.position.y - sbubLEFT.position.y) <= 0.5f)
        {
            transform.position = new Vector2(sbubLEFT.position.x, sbubLEFT.position.y);
            locked = true;
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
