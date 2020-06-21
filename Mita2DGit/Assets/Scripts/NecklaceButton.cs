using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecklaceButton : MonoBehaviour
{
    public float timer = 0f;
    public GameObject Flashback;
    public GameObject Buttoz;
    public GameObject Uselace;


    public void Flasher()
    {
        Flashback.SetActive(true);
        //Buttoz.SetActive(false);
        //Uselace.SetActive(true);
        timer = 2f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Flashback.SetActive(false);
            

        }
    }
}

