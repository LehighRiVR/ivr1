﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mira2b : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI mira2btextDisplay;
    public GameObject mira2bcontinueButton;
    public GameObject mira2bcloseButton;
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

            if (mira2btextDisplay.text == sentencesEN[indexEN] && indexEN <= 1)
            {
                mira2bcontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (mira2btextDisplay.text == sentencesSP[indexSP] && indexSP <= 1)
            {
                mira2bcontinueButton.SetActive(true);
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
            mira2btextDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            mira2btextDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        mira2bcontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                mira2btextDisplay.text = "";
                StartCoroutine(Type(sentencesEN));
            }

            if (indexEN == 2)
            {
                mira2bcloseButton.SetActive(true);
                mira2bcontinueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                mira2btextDisplay.text = "";
                StartCoroutine(Type(sentencesSP));
            }

            if (indexSP == 2)
            {
                mira2bcloseButton.SetActive(true);
                mira2bcontinueButton.SetActive(false);
            }
        }
    }
}
