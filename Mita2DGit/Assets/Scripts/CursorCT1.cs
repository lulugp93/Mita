using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorCT1 : MonoBehaviour
{
    public Texture2D cursorArrow;
    // Start is called before the first frame update
    void Start()
    {
        // Cursor.visible = false;
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

   
}
