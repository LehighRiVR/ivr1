using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenHelp : MonoBehaviour
{   
    public GameObject WorldCanvas;
    public GameObject helpCanvas;
    public GameObject helpDella;
    public GameObject helpLenni;
    public GameObject invisibleScreen;
    public GameObject locationPanel2;
    public GameObject Tooltip2;

    [Header("Controlled via script")]
    public GameObject NarrationBox;
    public GameObject Image360;
    public GameObject InnerCircle;
    public GameObject OuterCircle;
    public GameObject OuterCircleOutline;
    public GameObject ImageRaycast;
    public GameObject Click2LookAround;
    

    // Start is called before the first frame update
    void Awake()
    {
        WorldCanvas.SetActive(false);
        helpCanvas.SetActive(true);
        invisibleScreen.SetActive(true);
        helpLenni.SetActive(false);

        //Auto-populate these GameObjects in the Inspector

        NarrationBox = GameObject.Find("(Narration)");
        ImageRaycast = GameObject.Find("ClicktoLookAround(DEC06)");
        OuterCircle = GameObject.Find("OuterCircle");
        OuterCircleOutline = GameObject.Find("OuterCircle");
        InnerCircle = GameObject.Find("InnerCircle");
        Image360 = GameObject.Find("360Image");
        Click2LookAround = GameObject.Find("ClicktoLookAround(DEC06)");

        ImageRaycast.gameObject.GetComponent<Image>().enabled = false;
        OuterCircle.gameObject.GetComponent<Image>().enabled = false;
        OuterCircle.gameObject.GetComponentInChildren<Outline>().enabled = false;
        InnerCircle.gameObject.GetComponent<Image>().enabled = false;
        Image360.gameObject.GetComponent<Image>().enabled = false;
    }

    void Update()
    {
        if ((helpDella.activeSelf | helpLenni.activeSelf) && (Input.GetMouseButtonDown(0) | Input.GetMouseButtonDown(1)))
        {
                reminderOFF();
        }    
    }
    public void DellaHelp()
    {
        if (invisibleScreen.activeSelf == false)
        {
            helpDella.SetActive(true);
            locationPanel2.SetActive(true);
            WorldCanvas.SetActive(true);          
        }
        else helpDella.SetActive(false);
    }        

    public void NarrationCLOSE()
    {
        NarrationBox.SetActive(false);

        DellaHelp();

        Camera.main.GetComponent<LookAround>().enabled = true;

        ImageRaycast.gameObject.GetComponent<Image>().raycastTarget = true;
        OuterCircle.gameObject.GetComponent<Image>().enabled = true;
        OuterCircle.gameObject.GetComponentInChildren<Outline>().enabled = true;
        InnerCircle.gameObject.GetComponent<Image>().enabled = true;
        Image360.gameObject.GetComponent<Image>().enabled = true;
        Click2LookAround.gameObject.GetComponent<Image>().enabled = true;
        Click2LookAround.gameObject.GetComponent<Image>().fillCenter = true;
        Click2LookAround.gameObject.GetComponent<Image>().color = new Color32(0, 0, 0, 100);

        WorldCanvas.SetActive(true);
    }

    public void Click2LookAroundCLOSE()
    {
        Click2LookAround.SetActive(false);
        Tooltip2.SetActive(false);
        DellaHelp();
        Camera.main.GetComponent<LookAround>().enabled = true;
    }

    public void tooltipOFF()
    {
        Tooltip2.SetActive(false);
    }

    public void dellaOFF()
    {
        helpDella.SetActive(false);
    }

    public void lenniClickOFF()
    {
        helpLenni.SetActive(false);
    }

    public void reminderOFF()
    {  
            Invoke("dellaOFF", 0.5f);
            Invoke("lenniClickOFF", 0.5f);
    }
}
