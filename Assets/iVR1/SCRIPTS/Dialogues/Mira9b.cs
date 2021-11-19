using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mira9b : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI mira9btextDisplay;
    public GameObject mira9bcontinueButton;
    public GameObject mira9bcloseButton;
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

            if (mira9btextDisplay.text == sentencesEN[indexEN] && indexEN <= 3)
            {
                mira9bcontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (mira9btextDisplay.text == sentencesSP[indexSP] && indexSP <= 3)
            {
                mira9bcontinueButton.SetActive(true);
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
            mira9btextDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            mira9btextDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        mira9bcontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                mira9btextDisplay.text = "";
                StartCoroutine(Type(sentencesEN));
            }

            if (indexEN == 4)
            {
                mira9bcloseButton.SetActive(true);
                mira9bcontinueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                mira9btextDisplay.text = "";
                StartCoroutine(Type(sentencesSP));
            }

            if (indexSP == 4)
            {
                mira9bcloseButton.SetActive(true);
                mira9bcontinueButton.SetActive(false);
            }
        }
    }
}
