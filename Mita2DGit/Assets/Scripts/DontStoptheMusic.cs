using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontStoptheMusic : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
