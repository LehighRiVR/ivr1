using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lance4c : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI lance4ctextDisplay;
    public GameObject lance4ccontinueButton;
    public GameObject lance4ccloseButton;
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

            if (lance4ctextDisplay.text == sentencesEN[indexEN] && indexEN <= 3)
            {
                lance4ccontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (lance4ctextDisplay.text == sentencesSP[indexSP] && indexSP <= 3)
            {
                lance4ccontinueButton.SetActive(true);
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
            lance4ctextDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            lance4ctextDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        lance4ccontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                lance4ctextDisplay.text = "";
                StartCoroutine(Type(sentencesEN));
            }

            if (indexEN == 4)
            {
                lance4ccloseButton.SetActive(true);
                lance4ccontinueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                lance4ctextDisplay.text = "";
                StartCoroutine(Type(sentencesSP));
            }

            if (indexSP == 4)
            {
                lance4ccloseButton.SetActive(true);
                lance4ccontinueButton.SetActive(false);
            }
        }
    }
}
