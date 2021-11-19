using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class mira1HQ : MonoBehaviour
{
    public GameObject DialogueBox;

    public string[] sentencesEN;
    public string[] sentencesSP;

    private int indexEN;
    private int indexSP;

    [Header("Mira")]
    public TextMeshProUGUI mira1textDisplay;
    public GameObject mira1continueButton;
    public GameObject mira1closeButton;
    
    public string selectedLanguage;

    void Start()
    {        
        DialogueBox = GameObject.Find("DialogueBoxMira");

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

            if (mira1textDisplay.text == sentencesEN[indexEN] && indexEN <= 0)
            {
                mira1continueButton.SetActive(true);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            StartCoroutine(Type(sentencesSP));

            if (mira1textDisplay.text == sentencesSP[indexSP] && indexSP <= 0)
            {
                mira1continueButton.SetActive(true);
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
            mira1textDisplay.text = language[indexEN].ToString();
            yield return new WaitForSeconds(0);

        }
        else if (selectedLanguage == "Spanish")
        {
            mira1textDisplay.text = language[indexSP].ToString();
            yield return new WaitForSeconds(0);
        }
    }

    public void NextSentence()
    {
        mira1continueButton.SetActive(false);

        if (selectedLanguage == "English")
        {
            if (indexEN < sentencesEN.Length - 1)
            {
                indexEN++;
                mira1textDisplay.text = "";
            }

            if (indexEN == 1)
            {
                mira1closeButton.SetActive(true);
                mira1continueButton.SetActive(false);
            }
        }
        else if (selectedLanguage == "Spanish")
        {
            if (indexSP < sentencesSP.Length - 1)
            {
                indexSP++;
                mira1textDisplay.text = "";
            }

            if (indexSP == 1)
            {
                mira1closeButton.SetActive(true);
                mira1continueButton.SetActive(false);
            }
        }
    }
}
