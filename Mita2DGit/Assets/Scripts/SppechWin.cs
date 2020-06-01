using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SppechWin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (L_Bubble.locked && M_Bubble.locked && R_Bubble.locked)
        {
            SceneManager.LoadScene("PillMaze");
        }
    }
}
