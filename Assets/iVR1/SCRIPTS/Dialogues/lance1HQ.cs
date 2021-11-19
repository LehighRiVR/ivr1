using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class lance1HQ : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI lance1textDisplay;
    public GameObject lance1continueButton;
    public GameObject lance1closeButton;
    
    public string selectedLanguage;

    void Start()
    {
        DialogueBox = GameObject.Find("DialogueBoxLance");

        DialogueBox.SetActive(false);

        if (PlayerPrefs.GetString("language").Equals("English"))
        {
            selectedLanguage = "English";
        }
        else if (PlayerPrefs.GetString("language").Equals("Spanish"))
        {
            selectedLanguage = "Spanish";
        }

        Invoke("DialogueStart", 0.5f);
    }

    void Update()
    {
        if (selectedLanguage == "English")
        {
            StartCoroutine(Type(sentencesEN));

            if (lance1textDisplay.text == sentencesEN[indexEN] && indexEN <= 1)
            {
                lance1continueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (lance1textDisplay.text == sentencesSP[indexSP] && indexSP <= 1)
            {
                lance1continueButton.SetActive(true);
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
            lance1textDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            lance1textDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        lance1continueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                lance1textDisplay.text = "";
            }

            if (indexEN == 2)
            {
                lance1closeButton.SetActive(true);
                lance1continueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                lance1textDisplay.text = "";
            }

            if (indexSP == 2)
            {
                lance1closeButton.SetActive(true);
                lance1continueButton.SetActive(false);
            }
        }
    }
}

