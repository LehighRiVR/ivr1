using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mira9c : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    public TextMeshProUGUI mira9ctextDisplay;
    public GameObject mira9ccontinueButton;
    public GameObject mira9ccloseButton;
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

            if (mira9ctextDisplay.text == sentencesEN[indexEN] && indexEN <= 1)
            {
                mira9ccontinueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (mira9ctextDisplay.text == sentencesSP[indexSP] && indexSP <= 1)
            {
                mira9ccontinueButton.SetActive(true);
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
            mira9ctextDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            mira9ctextDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        mira9ccontinueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                mira9ctextDisplay.text = "";
                StartCoroutine(Type(sentencesEN));
            }

            if (indexEN == 2)
            {
                mira9ccloseButton.SetActive(true);
                mira9ccontinueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                mira9ctextDisplay.text = "";
                StartCoroutine(Type(sentencesSP));
            }

            if (indexSP == 2)
            {
                mira9ccloseButton.SetActive(true);
                mira9ccontinueButton.SetActive(false);
            }
        }
    }
}
