using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mira2a : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI mira2atextDisplay;
    public GameObject mira2acontinueButton;
    public GameObject mira2acloseButton;
    public string selectedLanguage;

    void Start()
    {
        DialogueBox = GameObject.Find("DialogueBox");

        DialogueBox.SetActive(false);

        if (PlayerPrefs.GetString("language").Equals("English"))
        {
            selectedLanguage = "English";
        }
        else if (PlayerPrefs.GetString("language").Equals("Spanish"))
        {
            selectedLanguage = "Spanish";
        }

        Invoke("DialogueStart", 1.5f);
    }

    void Update()
    {
        if (selectedLanguage == "English")
        {
            StartCoroutine(Type(sentencesEN));

            if (mira2atextDisplay.text == sentencesEN[indexEN] && indexEN <= 2)
            {
                mira2acontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (mira2atextDisplay.text == sentencesSP[indexSP] && indexSP <= 2)
            {
                mira2acontinueButton.SetActive(true);
            }
        }
    }

    void DialogueStart()
    {
        DialogueBox.SetActive(true);
    }

    IEnumerator Type(string[] language)
    {
        if (selectedLanguage == "English")
        {
            mira2atextDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            mira2atextDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        mira2acontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                mira2atextDisplay.text = "";
                StartCoroutine(Type(sentencesEN));
            }

            if (indexEN == 3)
            {
                mira2acloseButton.SetActive(true);
                mira2acontinueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                mira2atextDisplay.text = "";
                StartCoroutine(Type(sentencesSP));
            }

            if (indexSP == 3)
            {
                mira2acloseButton.SetActive(true);
                mira2acontinueButton.SetActive(false);
            }
        }
    }
}
