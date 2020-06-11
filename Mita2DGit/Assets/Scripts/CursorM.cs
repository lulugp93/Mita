using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorM : MonoBehaviour
{
    public Texture2D cursorArrow;
    // Start is called before the first frame update
    void Start()
    {
        // Cursor.visible = false;
        Cursor.SetCursor(cursorArrow, new Vector2(10,10), CursorMode.ForceSoftware);
    }

   
}
