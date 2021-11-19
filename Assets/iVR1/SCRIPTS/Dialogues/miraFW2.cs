using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class miraFW2 : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI miraFW2textDisplay;
    public GameObject miraFW2continueButton;
    public GameObject miraFW2closeButton;
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

            if (miraFW2textDisplay.text == sentencesEN[indexEN] && indexEN <= 2)
            {
                miraFW2continueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (miraFW2textDisplay.text == sentencesSP[indexSP] && indexSP <= 2)
            {
                miraFW2continueButton.SetActive(true);
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
            miraFW2textDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            miraFW2textDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        miraFW2continueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                miraFW2textDisplay.text = "";
                StartCoroutine(Type(sentencesEN));
            }

            if (indexEN == 3)
            {
                miraFW2closeButton.SetActive(true);
                miraFW2continueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                miraFW2textDisplay.text = "";
                StartCoroutine(Type(sentencesSP));
            }

            if (indexSP == 3)
            {
                miraFW2closeButton.SetActive(true);
                miraFW2continueButton.SetActive(false);
            }
        }
    }   
}
