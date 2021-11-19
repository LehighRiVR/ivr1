using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensInspect : MonoBehaviour
{
    //public Texture2D cursorDefault;

    public GameObject magicCircle;

    public Texture2D cursorLens;
    public Texture2D cursorDefault;
    public bool LensCursor;

    
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
        LensCursor = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (LensCursor == true && Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(cursorLens, Vector2.zero, CursorMode.Auto);
        }
        else if (LensCursor == false && Input.GetMouseButtonUp(0))
        {
            Cursor.SetCursor(cursorDefault, Vector2.zero, CursorMode.Auto);
        }
    }
    
    public void LensSwitchON()
    {
        LensCursor = true;
    }
    public void LensSwitchOFF()
    {
        LensCursor = false;
    }

}
