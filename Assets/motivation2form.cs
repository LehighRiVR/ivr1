using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class motivation2form : MonoBehaviour
{
    [SerializeField]
    private ScrollRect myScrollRect = null;
    [SerializeField]
    private Scrollbar newScrollBar;

    //private string ID;
    private string Item1;
    private string Item2;
    private string Item3;
    private string Item4;
    private string Item5;
    private string Item6;
    private string Item7;
    private string Item8;
    private string Item9;

    public Toggle[] m1;
    public Toggle[] m2;
    public Toggle[] m3;
    public Toggle[] m4;
    public Toggle[] m5;
    public Toggle[] m6;
    public Toggle[] m7;
    public Toggle[] m8;
    public Toggle[] m9;

    //check if each question is answered (PART A)
    public bool m1_ok = false;
    public bool m2_ok = false;
    public bool m3_ok = false;
    public bool m4_ok = false;
    public bool m5_ok = false;
    public bool m6_ok = false;
    public bool m7_ok = false;
    public bool m8_ok = false;
    public bool m9_ok = false;

    //check if each question is answered (PART B)
    #region CHECKED?
    public void m1CHECKED()
    {
        m1_ok = true;
    }

    public void m2CHECKED()
    {
        m2_ok = true;
    }

    public void m3CHECKED()
    {
        m3_ok = true;
    }

    public void m4CHECKED()
    {
        m4_ok = true;
    }

    public void m5CHECKED()
    {
        m5_ok = true;
    }

    public void m6CHECKED()
    {
        m6_ok = true;
    }

    public void m7CHECKED()
    {
        m7_ok = true;
    }

    public void m8CHECKED()
    {
        m8_ok = true;
    }

    public void m9CHECKED()
    {
        m9_ok = true;
    }
    #endregion

    // PART C: drag this script into each respective GameObject containing the ToggleGroup component, and activate the function [OnValueChanged]

    // deactivate the reminder & activate the SUBMIT button

    public GameObject helpText;
    public GameObject submitButton;

    public void showSUBMIT()
    {
        if ((m1_ok) && (m2_ok) && (m3_ok) && (m4_ok) && (m5_ok) && (m6_ok) && (m7_ok) && (m8_ok) && (m9_ok))
        {
            helpText.SetActive(false);
            submitButton.SetActive(true);
        }
    }

    public void Start()
    {
        //Change the current vertical scroll position.
        myScrollRect.verticalNormalizedPosition = 1f;
    }

    public void Update()
    {
        showSUBMIT();
    }

    [SerializeField]
    private string motivation_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSfbR_IitU1fVXdENKIoinWbN36WvdpyoeMwmwXCkeZEib9oUQ/formResponse";

    IEnumerator PostMOTIVATION(string item1, string item2, string item3, string item4, string item5, string item6, string item7, string item8, string item9)
    {
        WWWForm motivation = new WWWForm();

        motivation.AddField("entry.897496909", item1);
        motivation.AddField("entry.1132375028", item2);
        motivation.AddField("entry.581636757", item3);
        motivation.AddField("entry.1266763376", item4);
        motivation.AddField("entry.159787231", item5);
        motivation.AddField("entry.326293667", item6);
        motivation.AddField("entry.1763777675", item7);
        motivation.AddField("entry.1646020989", item8);
        motivation.AddField("entry.542650384", item9);

        UnityWebRequest WWW = UnityWebRequest.Post(motivation_URL, motivation);
        yield return WWW.SendWebRequest();

    }

    public void SendMOTIVATION()
    {
        for (int i = 0; i < 5; i++)
        {
            if (m1[i].isOn)
            {
                Item1 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (m2[i].isOn)
            {
                Item2 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (m3[i].isOn)
            {
                Item3 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (m4[i].isOn)
            {
                Item4 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (m5[i].isOn)
            {
                Item5 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (m6[i].isOn)
            {
                Item6 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (m7[i].isOn)
            {
                Item7 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (m8[i].isOn)
            {
                Item8 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (m9[i].isOn)
            {
                Item9 = (i + 1).ToString();
            }
        }

        StartCoroutine(PostMOTIVATION(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9));
        
    }

    //Debug.Log("Your information was sent. Thank you! ");
}
