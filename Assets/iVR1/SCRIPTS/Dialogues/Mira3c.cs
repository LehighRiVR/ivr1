using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mira3c : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI mira3ctextDisplay;
    public GameObject mira3ccontinueButton;
    public GameObject mira3ccloseButton;
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

            if (mira3ctextDisplay.text == sentencesEN[indexEN] && indexEN <= 4)
            {
                mira3ccontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (mira3ctextDisplay.text == sentencesSP[indexSP] && indexSP <= 4)
            {
                mira3ccontinueButton.SetActive(true);
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
            mira3ctextDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            mira3ctextDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        mira3ccontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                mira3ctextDisplay.text = "";
                StartCoroutine(Type(sentencesEN));
            }

            if (indexEN == 5)
            {
                mira3ccloseButton.SetActive(true);
                mira3ccontinueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                mira3ctextDisplay.text = "";
                StartCoroutine(Type(sentencesSP));
            }

            if (indexSP == 5)
            {
                mira3ccloseButton.SetActive(true);
                mira3ccontinueButton.SetActive(false);
            }
        }
    }
}
