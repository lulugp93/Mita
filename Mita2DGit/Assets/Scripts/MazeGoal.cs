using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MazeGoal : MonoBehaviour, IDropHandler
{
   
    public void OnDrop(PointerEventData eventData)
    {
        var pillPoint = 0;
        Debug.Log("1 pill has reached the goal ");
        pillPoint++;

        if(pillPoint == 2)
        {
            Debug.Log("u did it!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
