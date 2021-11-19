using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mira9a : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI mira9atextDisplay;
    public GameObject mira9acontinueButton;
    public GameObject mira9acloseButton;
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

            if (mira9atextDisplay.text == sentencesEN[indexEN] && indexEN <= 4)
            {
                mira9acontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (mira9atextDisplay.text == sentencesSP[indexSP] && indexSP <= 4)
            {
                mira9acontinueButton.SetActive(true);
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
            mira9atextDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            mira9atextDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        mira9acontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                mira9atextDisplay.text = "";
                StartCoroutine(Type(sentencesEN));
            }

            if (indexEN == 5)
            {
                mira9acloseButton.SetActive(true);
                mira9acontinueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                mira9atextDisplay.text = "";
                StartCoroutine(Type(sentencesSP));
            }

            if (indexSP == 5)
            {
                mira9acloseButton.SetActive(true);
                mira9acontinueButton.SetActive(false);
            }
        }
    }
}