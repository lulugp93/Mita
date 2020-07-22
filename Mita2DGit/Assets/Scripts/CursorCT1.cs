using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorCT1 : MonoBehaviour
{
    public Texture2D cursorArrow;
    public Texture2D CT2Cursor;
    // Start is called before the first frame update
    void Start()
    {
        // Cursor.visible = false;
        if (DayCounter.DayPoints == 0 || DayCounter.DayPoints == 19)
        {
            Cursor.SetCursor(cursorArrow, new Vector2(10, 10), CursorMode.ForceSoftware);
        }

        if (DayCounter.DayPoints == 10)
        {
            Cursor.SetCursor(CT2Cursor, new Vector2(10, 10), CursorMode.ForceSoftware);
        }
    }

   
}
