using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lance4a : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI lance4atextDisplay;
    public GameObject lance4acontinueButton;
    public GameObject lance4acloseButton;
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
        StartCoroutine(Type(sentencesEN));

        if (selectedLanguage == "English")
        {
            if (lance4atextDisplay.text == sentencesEN[indexEN] && indexEN <= 3)
            {
                lance4acontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (lance4atextDisplay.text == sentencesSP[indexSP] && indexSP <= 3)
            {
                lance4acontinueButton.SetActive(true);
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
            lance4atextDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            lance4atextDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        lance4acontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                lance4atextDisplay.text = "";
                StartCoroutine(Type(sentencesEN));
            }

            if (indexEN == 4)
            {
                lance4acloseButton.SetActive(true);
                lance4acontinueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                lance4atextDisplay.text = "";
                StartCoroutine(Type(sentencesSP));
            }

            if (indexSP == 4)
            {
                lance4acloseButton.SetActive(true);
                lance4acontinueButton.SetActive(false);
            }
        }
    }
}
