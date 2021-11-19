using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lance5 : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI lance5textDisplay;
    public GameObject lance5continueButton;
    public GameObject lance5closeButton;
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

            if (lance5textDisplay.text == sentencesEN[indexEN] && indexEN <= 3)
            {
                lance5continueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (lance5textDisplay.text == sentencesSP[indexSP] && indexSP <= 3)
            {
                lance5continueButton.SetActive(true);
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
            lance5textDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            lance5textDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        lance5continueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                lance5textDisplay.text = "";
                StartCoroutine(Type(sentencesEN));
            }

            if (indexEN == 4)
            {
                lance5closeButton.SetActive(true);
                lance5continueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                lance5textDisplay.text = "";
                StartCoroutine(Type(sentencesSP));
            }

            if (indexSP == 4)
            {
                lance5closeButton.SetActive(true);
                lance5continueButton.SetActive(false);
            }
        }
    }
}
