using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class perception2form : MonoBehaviour
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

    public Toggle[] p1;
    public Toggle[] p2;
    public Toggle[] p3;
    public Toggle[] p4;
    public Toggle[] p5;
    public Toggle[] p6;
    public Toggle[] p7;
    public Toggle[] p8;
    public Toggle[] p9;

    //check if each question is answered (PART A)
    public bool p1_ok = false;
    public bool p2_ok = false;
    public bool p3_ok = false;
    public bool p4_ok = false;
    public bool p5_ok = false;
    public bool p6_ok = false;
    public bool p7_ok = false;
    public bool p8_ok = false;
    public bool p9_ok = false;

    //check if each question is answered (PART B)
    #region CHECKED?
    public void p1CHECKED()
    {
        p1_ok = true;
    }

    public void p2CHECKED()
    {
        p2_ok = true;
    }

    public void p3CHECKED()
    {
        p3_ok = true;
    }

    public void p4CHECKED()
    {
        p4_ok = true;
    }

    public void p5CHECKED()
    {
        p5_ok = true;
    }

    public void p6CHECKED()
    {
        p6_ok = true;
    }

    public void p7CHECKED()
    {
        p7_ok = true;
    }

    public void p8CHECKED()
    {
        p8_ok = true;
    }

    public void p9CHECKED()
    {
        p9_ok = true;
    }
    #endregion

    // PART C: drag this script into each respective GameObject containing the ToggleGroup component, and activate the function [OnValueChanged]

    // deactivate the reminder & activate the SUBMIT button

    public GameObject helpText;
    public GameObject submitButton;

    public void showSUBMIT()
    {
        if ((p1_ok) && (p2_ok) && (p3_ok) && (p4_ok) && (p5_ok) && (p6_ok) && (p7_ok) && (p8_ok) && (p9_ok))
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
    private string perception_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSdMaWnyJ60FqjAaHUlHNLrVtzC5n6n_lVJSVDmqmClj9trWAQ/formResponse";

    IEnumerator PostPERCEPTION(string item1, string item2, string item3, string item4, string item5, string item6, string item7, string item8, string item9)
    {
        WWWForm perception = new WWWForm();

        perception.AddField("entry.897496909", item1);
        perception.AddField("entry.1132375028", item2);
        perception.AddField("entry.581636757", item3);
        perception.AddField("entry.1266763376", item4);
        perception.AddField("entry.159787231", item5);
        perception.AddField("entry.326293667", item6);
        perception.AddField("entry.1763777675", item7);
        perception.AddField("entry.1646020989", item8);
        perception.AddField("entry.542650384", item9);

        UnityWebRequest WWW = UnityWebRequest.Post(perception_URL, perception);
        yield return WWW.SendWebRequest();
    }
    public void SendPERCEPTION()
    {
        for (int i = 0; i < 5; i++)
        {
            if (p1[i].isOn)
            {
                Item1 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (p2[i].isOn)
            {
                Item2 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (p3[i].isOn)
            {
                Item3 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (p4[i].isOn)
            {
                Item4 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (p5[i].isOn)
            {
                Item5 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (p6[i].isOn)
            {
                Item6 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (p7[i].isOn)
            {
                Item7 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (p8[i].isOn)
            {
                Item8 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (p9[i].isOn)
            {
                Item9 = (i + 1).ToString();
            }
        }

        StartCoroutine(PostPERCEPTION(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9));

    }

    //Debug.Log("Your information was sent. Thank you! ");
}
