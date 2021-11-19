using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mira3b : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI mira3btextDisplay;
    public GameObject mira3bcontinueButton;
    public GameObject mira3bcloseButton;
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

            if (mira3btextDisplay.text == sentencesEN[indexEN] && indexEN <= 0)
            {
                mira3bcontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (mira3btextDisplay.text == sentencesSP[indexSP] && indexSP <= 0)
            {
                mira3bcontinueButton.SetActive(true);
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
            mira3btextDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            mira3btextDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        mira3bcontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                mira3btextDisplay.text = "";
                StartCoroutine(Type(sentencesEN));
            }

            if (indexEN == 1)
            {
                mira3bcloseButton.SetActive(true);
                mira3bcontinueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                mira3btextDisplay.text = "";
                StartCoroutine(Type(sentencesSP));
            }

            if (indexSP == 1)
            {
                mira3bcloseButton.SetActive(true);
                mira3bcontinueButton.SetActive(false);
            }
        }
    }
}
