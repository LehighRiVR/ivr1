using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lance4b : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI lance4btextDisplay;
    public GameObject lance4bcontinueButton;
    public GameObject lance4bcloseButton;
    public string selectedLanguage;

    void Start()
    {
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

            if (lance4btextDisplay.text == sentencesEN[indexEN] && indexEN <= 4)
            {
                lance4bcontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (lance4btextDisplay.text == sentencesSP[indexSP] && indexSP <= 4)
            {
                lance4bcontinueButton.SetActive(true);
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
            lance4btextDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            lance4btextDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        lance4bcontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                lance4btextDisplay.text = "";
                StartCoroutine(Type(sentencesEN));
            }

            if (indexEN == 5)
            {
                lance4bcloseButton.SetActive(true);
                lance4bcontinueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                lance4btextDisplay.text = "";
                StartCoroutine(Type(sentencesSP));
            }

            if (indexSP == 5)
            {
                lance4bcloseButton.SetActive(true);
                lance4bcontinueButton.SetActive(false);
            }
        }
    }
}
