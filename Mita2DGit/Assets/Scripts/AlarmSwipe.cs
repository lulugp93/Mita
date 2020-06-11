using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AlarmSwipe : MonoBehaviour
{

    public GameObject Phone;
    public float x1;
    public float x2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            x1 = Input.mousePosition.x;
        }

        if (Input.GetMouseButtonUp(0))
        {
            x2 = Input.mousePosition.x;

            if (x2 > x1)
            {
                Destroy(Phone);
                SceneManager.LoadScene("Day1_P2");
            }
        }
    }
}
