using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameOptions : MonoBehaviour
{
    public GameObject lightBulbON;
    public GameObject lightBulbOFF;
    public GameObject click2lookAround;
    public GameObject ScreenHelpCanvas;
    public GameObject buttonOn;
    public GameObject buttonOff;
    

    // Start is called before the first frame update
    void Start()
    {
        //ScreenHelpCanvas = GameObject.Find("ScreenHelpCanvas");

     #region ScreenHelp (Int)

     PlayerPrefs.GetInt("ScreenHelp");
     
     if (PlayerPrefs.GetInt("ScreenHelp") == 1)
     {
         ScreenHelpCanvas.SetActive(true);
            //Debug.Log(PlayerPrefs.GetString("ScreenHelp"));
            lightBulbON.SetActive(true);
        }
     else if (PlayerPrefs.GetInt("ScreenHelp") == 0)
     {
         ScreenHelpCanvas.SetActive(false);
           // Debug.Log(PlayerPrefs.GetString("ScreenHelp"));
            lightBulbON.SetActive(false);
        }

     #endregion

        #region Language
        PlayerPrefs.GetString("language");
        //Debug.Log(PlayerPrefs.GetString("language"));

        if (PlayerPrefs.HasKey("English"))
        {
            LocalizationSystem.language = "English";
        }
        else if (PlayerPrefs.HasKey("Spanish"))
        {
            LocalizationSystem.language = "Spanish";
        }
        #endregion     

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("ScreenHelp") == 1)
        {
            turnONscreenHelp();
        }
        else if (PlayerPrefs.GetInt("ScreenHelp") == 0)
        {
            turnOFFscreenHelp();
        }
    }

    public void turnONscreenHelp()
    {               
        PlayerPrefs.SetInt("ScreenHelp", 1);
        //Debug.Log(PlayerPrefs.GetInt("ScreenHelp"));
        LightsON();
        buttonOn.GetComponent<Image>().color = new Color32(222, 182, 56, 255);
        buttonOff.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }

    public void LightsON()
    {
        ScreenHelpCanvas.SetActive(true);
        lightBulbON.SetActive(true);
        lightBulbOFF.SetActive(false);
        
        click2lookAround.SetActive(false);
    }

    public void turnOFFscreenHelp()
    {
        PlayerPrefs.SetInt("ScreenHelp", 0);
        //Debug.Log(PlayerPrefs.GetInt("ScreenHelp"));
        LightsOFF();
        buttonOff.GetComponent<Image>().color = new Color32(222, 182, 56, 255);
        buttonOn.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }

    public void LightsOFF()
    {
        ScreenHelpCanvas.SetActive(false);
        lightBulbON.SetActive(false);
        lightBulbOFF.SetActive(true);
    }

}

