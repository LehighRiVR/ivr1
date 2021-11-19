using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class demographics2form : MonoBehaviour
{
    public GameObject demographics;
    
    //private string ID;
    private string Item1;
    private string Item2;
    private string Item3;
    private string Item4;

    public Toggle[] d1;
    public Toggle[] d2;
    public Toggle[] d3;
    public Toggle[] d4;
  

    //check if each question is answered (PART A)
    public bool d1_ok = false;
    public bool d2_ok = false;
    public bool d3_ok = false;
    public bool d4_ok = false;
   
    //check if each question is answered (PART B)
    #region CHECKED?
    public void d1CHECKED()
    {
        d1_ok = true;
    }

    public void d2CHECKED()
    {
        d2_ok = true;
    }

    public void d3CHECKED()
    {
        d3_ok = true;
    }

    public void d4CHECKED()
    {
        d4_ok = true;
    }    
    #endregion

    // PART C: drag this script into each respective GameObject containing the ToggleGroup component, and activate the function [OnValueChanged]

    // deactivate the reminder & activate the SUBMIT button

    public GameObject helpText;
    public GameObject submitButton;

    public void showSUBMIT()
    {
        if ((d1_ok) && (d2_ok) && (d3_ok) && (d4_ok))
        {
            helpText.SetActive(false);
            submitButton.SetActive(true);
        }
    }

    public void Update()
    {
        showSUBMIT();
    }

    #region DEMOGRAPHICS SURVEY
    [SerializeField]
    private string demographics_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSc4Fdp-kVtNeHVGYJ8yqHRRReuSNZkaIMdUiHKGKNjWpQnbiA/formResponse";

    IEnumerator PostDEMOGRAPHICS(string item1, string item2, string item3, string item4)
    {
        WWWForm demographics = new WWWForm();

        demographics.AddField("entry.897496909", item1);
        demographics.AddField("entry.1132375028", item2);
        demographics.AddField("entry.581636757", item3);
        demographics.AddField("entry.1266763376", item4);
        

        UnityWebRequest WWW = UnityWebRequest.Post(demographics_URL, demographics);
        yield return WWW.SendWebRequest();
    }
    public void SendDEMOGRAPHICS()
    {
        for (int i = 0; i < 2; i++)
        {
            if (d1[i].isOn)
            {
                Item1 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (d2[i].isOn)
            {
                Item2 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (d3[i].isOn)
            {
                Item3 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 8; i++)
        {
            if (d4[i].isOn)
            {
                Item4 = (i + 1).ToString();
            }
        }
        
        StartCoroutine(PostDEMOGRAPHICS(Item1, Item2, Item3, Item4));
    }

    //Debug.Log("Your information was sent. Thank you! ");
    #endregion

}