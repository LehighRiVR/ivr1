using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class survey2form : MonoBehaviour
{   
    public GameObject wlpretest;
    public GameObject wlpostest;

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

    public Toggle[] t1;
    public Toggle[] t2;
    public Toggle[] t3;
    public Toggle[] t4;
    public Toggle[] t5;
    public Toggle[] t6;
    public Toggle[] t7;
    public Toggle[] t8;
    public Toggle[] t9;

    //check if each question is answered (PART A)
    public bool t1_ok = false;
    public bool t2_ok = false;
    public bool t3_ok = false;
    public bool t4_ok = false;
    public bool t5_ok = false;
    public bool t6_ok = false;
    public bool t7_ok = false;
    public bool t8_ok = false;
    public bool t9_ok = false;

    //check if each question is answered (PART B)
    #region CHECKED?
    public void t1CHECKED()
    {
        t1_ok = true;
    }

    public void t2CHECKED()
    {
        t2_ok = true;
    }

    public void t3CHECKED()
    {
        t3_ok = true;
    }

    public void t4CHECKED()
    {
        t4_ok = true;
    }

    public void t5CHECKED()
    {
        t5_ok = true;
    }

    public void t6CHECKED()
    {
        t6_ok = true;
    }

    public void t7CHECKED()
    {
        t7_ok = true;
    }

    public void t8CHECKED()
    {
        t8_ok = true;
    }

    public void t9CHECKED()
    {
        t9_ok = true;
    }
    #endregion

    // PART C: drag this script into each respective GameObject containing the ToggleGroup component, and activate the function [OnValueChanged]

    // deactivate the reminder & activate the SUBMIT button

    public GameObject helpText;
    public GameObject submitButton;

    public void showSUBMIT()
    {
        if ((t1_ok) && (t2_ok) && (t3_ok) && (t4_ok) && (t5_ok) && (t6_ok) && (t7_ok) && (t8_ok) && (t9_ok))
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
    
    #region PRETEST WL
    [SerializeField]
    private string pretest_URL = "https://docs.google.com/forms/d/e/1FAIpQLSeoX1guSxfk5Lp4_s1uqZmu-8zL6XpK1muS1oNtCUdg-3ubZw/formResponse";

    IEnumerator PostPRE(string item1, string item2, string item3, string item4, string item5, string item6, string item7, string item8, string item9)
    {
            WWWForm pretest = new WWWForm();

            pretest.AddField("entry.897496909", item1);
            pretest.AddField("entry.1132375028", item2);
            pretest.AddField("entry.581636757", item3);
            pretest.AddField("entry.1266763376", item4);
            pretest.AddField("entry.159787231", item5);
            pretest.AddField("entry.326293667", item6);
            pretest.AddField("entry.1763777675", item7);
            pretest.AddField("entry.1646020989", item8);
            pretest.AddField("entry.542650384", item9);

            UnityWebRequest WWW = UnityWebRequest.Post(pretest_URL, pretest);
            yield return WWW.SendWebRequest();              
    }

    public void SendPRETEST()
    {
        for (int i = 0; i < 2; i++)
        {
            if (t1[i].isOn)
            {
                Item1 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 2; i++)
        {
            if (t2[i].isOn)
            {
                Item2 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 2; i++)
        {
            if (t3[i].isOn)
            {
                Item3 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 2; i++)
        {
            if (t4[i].isOn)
            {
                Item4 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 2; i++)
        {
            if (t5[i].isOn)
            {
                Item5 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 2; i++)
        {
            if (t6[i].isOn)
            {
                Item6 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 2; i++)
        {
            if (t7[i].isOn)
            {
                Item7 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 4; i++)
        {
            if (t8[i].isOn)
            {
                Item8 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (t9[i].isOn)
            {
                Item9 = (i + 1).ToString();
            }
        }

        StartCoroutine(PostPRE(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9));

        //Debug.Log("Your information was sent. Thank you! ");
    }
#endregion

    #region POSTTEST WL
    [SerializeField]
    private string postest_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSdWp26gWUuwQZK1WR1XZMXVdOf6Rz71zZPVJKzYvH_dSPRzEg/formResponse";

    IEnumerator PostPOST(string item1, string item2, string item3, string item4, string item5, string item6, string item7, string item8, string item9)
    {
        WWWForm postest = new WWWForm();

        postest.AddField("entry.1132375028", item1);
        postest.AddField("entry.159787231", item2);
        postest.AddField("entry.897496909", item3);
        postest.AddField("entry.581636757", item4);
        postest.AddField("entry.326293667", item5);
        postest.AddField("entry.1763777675", item6);
        postest.AddField("entry.1266763376", item7);
        postest.AddField("entry.1646020989", item8);
        postest.AddField("entry.542650384", item9);

        UnityWebRequest WWW = UnityWebRequest.Post(postest_URL, postest);
        yield return WWW.SendWebRequest();
    }

    public void SendPOSTEST()
    {
        for (int i = 0; i < 2; i++)
        {
            if (t1[i].isOn)
            {
                Item1 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 2; i++)
        {
            if (t2[i].isOn)
            {
                Item2 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 2; i++)
        {
            if (t3[i].isOn)
            {
                Item3 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 2; i++)
        {
            if (t4[i].isOn)
            {
                Item4 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 2; i++)
        {
            if (t5[i].isOn)
            {
                Item5 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 2; i++)
        {
            if (t6[i].isOn)
            {
                Item6 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 2; i++)
        {
            if (t7[i].isOn)
            {
                Item7 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 4; i++)
        {
            if (t8[i].isOn)
            {
                Item8 = (i + 1).ToString();
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (t9[i].isOn)
            {
                Item9 = (i + 1).ToString();
            }
        }

        StartCoroutine(PostPOST(Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9));
    }

        //Debug.Log("Your information was sent. Thank you! ");

        #endregion
}